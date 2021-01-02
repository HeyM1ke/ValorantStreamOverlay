using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Text.RegularExpressions;

namespace ValorantStreamOverlay
{


    class LogicHandler
    {
        public static string AccessToken { get; set; }
        public static string EntitlementToken { get; set; }
        public static string UserID { get; set; }

        public static string username, password, region;
        public static int refreshTimeinSeconds;
        public Timer relogTimer, pointTimer;

        public static ValorantOverStream ValorantOver;
        public LogicHandler logic;
        public RankDetection rankDetect;

        //Twitch Bot Variables
        public static int currentRankPoints, currentMMRorELO;
        private bool botEnabled;

        public LogicHandler(ValorantOverStream instance)
        {
            logic = this;
            ValorantOver = instance;

            Trace.Write("Reading Settings");
            ReadSettings();
        }

        void ReadSettings()
        {

            if (string.IsNullOrEmpty(Properties.Settings.Default.password) || string.IsNullOrEmpty(Properties.Settings.Default.username))
            {
                MessageBox.Show("You have to set your username and password in the settings menu", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Settings settingsPage = new Settings();
                settingsPage.ShowDialog();
            }
            else
            {
                username = Properties.Settings.Default.username;
                password = Properties.Settings.Default.password;
                region = new SettingsParser().ReadRegion(Properties.Settings.Default.region).GetAwaiter().GetResult();
                refreshTimeinSeconds = new SettingsParser().ReadDelay(Properties.Settings.Default.region).GetAwaiter().GetResult();
                new SettingsParser().ReadSkin(Properties.Settings.Default.skin).GetAwaiter();
                botEnabled = new SettingsParser().ReadTwitchBot().GetAwaiter().GetResult();

                RiotGamesLogin();

                UpdateToLatestGames();
                new RankDetection();

                StartPointRefresh();
                StartRELOGTimer();
                StartTwitchBot();
            }

        }


        void RiotGamesLogin()
        {
            try
            {
                CookieContainer cookie = new CookieContainer();
                Authentication.GetAuthorization(cookie);

                var authJson = JsonConvert.DeserializeObject(Authentication.Authenticate(cookie, username, password));
                JToken authObj = JObject.FromObject(authJson);

                if (authObj.ToString().Contains("error"))
                {
                    // error time lmfao
                    MessageBox.Show("Login is Incorrect, please fix login in settings.");
                }
                else
                {
                    string authURL = authObj["response"]["parameters"]["uri"].Value<string>();
                    var access_tokenVar = Regex.Match(authURL, @"access_token=(.+?)&scope=").Groups[1].Value;
                    AccessToken = $"{access_tokenVar}";

                    RestClient client = new RestClient(new Uri("https://entitlements.auth.riotgames.com/api/token/v1"));
                    RestRequest request = new RestRequest(Method.POST);

                    request.AddHeader("Authorization", $"Bearer {AccessToken}");
                    request.AddJsonBody("{}");

                    string response = client.Execute(request).Content;
                    var entitlement_token = JsonConvert.DeserializeObject(response);
                    JToken entitlement_tokenObj = JObject.FromObject(entitlement_token);

                    EntitlementToken = entitlement_tokenObj["entitlements_token"].Value<string>();


                    RestClient userid_client = new RestClient(new Uri("https://auth.riotgames.com/userinfo"));
                    RestRequest userid_request = new RestRequest(Method.POST);

                    userid_request.AddHeader("Authorization", $"Bearer {AccessToken}");
                    userid_request.AddJsonBody("{}");

                    string userid_response = userid_client.Execute(userid_request).Content;
                    dynamic userid = JsonConvert.DeserializeObject(userid_response);
                    JToken useridObj = JObject.FromObject(userid);

                    //Console.WriteLine(userid_response);

                    UserID = useridObj["sub"].Value<string>();
                }




            }
            catch (Exception e)
            {
                MessageBox.Show("Your Login was invalid, please check your settings.");
            }
        }

        async Task UpdateToLatestGames()
        {
            Trace.Write("UPDATING");
            var response = GetCompApiAsync().GetAwaiter().GetResult();
            if (response != null)
            {
                var gameStats = new List<Tuple<int, Game.CompetitiveMovements>>();
                var matches = JsonConvert.DeserializeObject<Game[]>(response["Matches"].ToString());
                foreach (var game in matches)
                {
                    // not a ranked game
                    if (game.GetCompetitiveMovement == Game.CompetitiveMovements.MovementUnknown)
                        continue;

                    gameStats.Add(Tuple.Create(game.Points, game.GetCompetitiveMovement));

                    if (gameStats.Count >= 3) // 3 recent matches found
                        break;
                }

                //Send Points to Function that changes the UI
                SetChangesToOverlay(gameStats).GetAwaiter();
            }
        }

        private async Task<JObject> GetCompApiAsync()
        {
            IRestClient compClient = new RestClient(new Uri($"https://pd.{region}.a.pvp.net/mmr/v1/players/{UserID}/competitiveupdates?startIndex=0&endIndex=20"));
            RestRequest compRequest = new RestRequest(Method.GET);

            compRequest.AddHeader("Authorization", $"Bearer {AccessToken}");
            compRequest.AddHeader("X-Riot-Entitlements-JWT", EntitlementToken);

            IRestResponse rankedResp = compClient.Get(compRequest);

            return rankedResp.IsSuccessful ? JsonConvert.DeserializeObject<JObject>(rankedResp.Content) : null;
        }

        private async Task SetChangesToOverlay(List<Tuple<int, Game.CompetitiveMovements>> gameStats)
        {
            var asd = Tuple.Create(ValorantOver.recentGame1, ValorantOver.recentGame1_status);
            var rankChanges = new[] {
                Tuple.Create(ValorantOver.recentGame1, ValorantOver.recentGame1_status),
                Tuple.Create(ValorantOver.recentGame2, ValorantOver.recentGame2_status),
                Tuple.Create(ValorantOver.recentGame3, ValorantOver.recentGame3_status)
            };
            for (int i = 0; i < gameStats.Count; i++)
            {
                // neg num represents decrease in pts
                var points = gameStats[i].Item1;

                if (points == 0)
                {
                    rankChanges[i].Item1.ForeColor = Color.SlateGray;
                    rankChanges[i].Item1.Text = "0";
                }
                else
                {
                    var pointsText = $"{Math.Abs(points).ToString().PadLeft(2, '0')}";
                    if (points < 0)
                    {
                        //In the case of a demotion or a loss
                        rankChanges[i].Item1.ForeColor = Color.Red;
                        rankChanges[i].Item1.Text = $"-{pointsText}";
                    }
                    else if (points > 0)
                    {
                        rankChanges[i].Item1.ForeColor = Color.LimeGreen;
                        rankChanges[i].Item1.Text = $"+{pointsText}";
                    }
                }
                
                var resource = Properties.Resources.ResourceManager.GetObject($"TX_CompetitiveTierMovement_{Enum.GetName(typeof(Game.CompetitiveMovements), gameStats[i].Item2)}");
                Bitmap myImage = (Bitmap)resource;
                rankChanges[i].Item2.Image = myImage;
            }
        }

        private void StartPointRefresh()
        {
            pointTimer = new Timer();
            pointTimer.Tick += new EventHandler(pointTimer_Tick);
            pointTimer.Interval = refreshTimeinSeconds * 1000;
            pointTimer.Start();
        }

        private void pointTimer_Tick(object sender, EventArgs e)
        {
            UpdateToLatestGames().GetAwaiter();

            if (rankDetect == null)
            {
                rankDetect = new RankDetection();
            }
            else
            {
                rankDetect.UpdateRank();
            }
        }

        private void StartRELOGTimer()
        {
            relogTimer = new Timer();
            relogTimer.Tick += new EventHandler(relogTimer_Tick);
            relogTimer.Interval = 2700 * 1000;
            relogTimer.Start();

        }

        private void relogTimer_Tick(object sender, EventArgs e)
        {
            pointTimer.Stop();
            RiotGamesLogin();
            pointTimer.Start();
        }

        public void StartTwitchBot()
        {
            if (botEnabled)
            {
                Trace.WriteLine("Bot enabled");
                TwitchIntegration bot = new TwitchIntegration();
            }
            else
            {
                Trace.WriteLine("Bot not enabled");
            }
        }
    }
}
