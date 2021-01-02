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

        public static string username, password, region, language;
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
                MessageBox.Show("Welcome, You have to set your username and password in the settings menu");
            else
            {
                username = Properties.Settings.Default.username;
                password = Properties.Settings.Default.password;
                region = new SettingsParser().ReadRegion(Properties.Settings.Default.region).GetAwaiter().GetResult();
                refreshTimeinSeconds = new SettingsParser().ReadDelay(Properties.Settings.Default.region).GetAwaiter().GetResult();
                language = new SettingsParser().ReadLanguage(Properties.Settings.Default.language).GetAwaiter().GetResult();
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
            dynamic response = GetCompApiAsync().GetAwaiter().GetResult();
            if (response != null)
            {
                int[] points = new int[3];
                dynamic matches = response["Matches"];
                int count = 0, i  = 0;
                foreach (var game in matches)
                {

                    if (game["CompetitiveMovement"] == "MOVEMENT_UNKNOWN")
                    {
                        // not a ranked game
                    }
                    else if (game["CompetitiveMovement"] == "PROMOTED")
                    {
                        // player promoted
                        int before = game["TierProgressBeforeUpdate"];
                        int after = game["TierProgressAfterUpdate"];
                        int differ = (after - before) + 100; 
                        points[i++] = differ;
                        count++;
                    }
                    else if (game["CompetitiveMovement"] == "DEMOTED")
                    {
                        // player demoted
                        int before = game["TierProgressBeforeUpdate"];
                        int after = game["TierProgressAfterUpdate"];
                        int differ = (after - before) - 100; 
                        points[i++] = differ;
                        count++;
                    }
                    else
                    {
                        int before = game["TierProgressBeforeUpdate"];
                        int after = game["TierProgressAfterUpdate"];
                        points[i++] = after - before;
                        count++;
                    }

                    if (count >= 3) // 3 recent matches found
                        break;
                }
                //Send Points to Function that changes the UI
                SetChangesToOverlay(points).GetAwaiter();
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


        private async Task SetChangesToOverlay(int[] pointchange)
        {
            Label[] rankChanges = { ValorantOver.recentGame1, ValorantOver.recentGame2, ValorantOver.recentGame3 };
            for (int i = 0; i < pointchange.Length; i++)
            {
                // neg num represents decrease in pts
                if (pointchange[i] < 0)
                {
                    //In the case of a demotion or a loss
                    pointchange[i] *= -1;
                    string change;
                    change = pointchange[i] <= 9 ? $"0{pointchange[i]}" : pointchange[i].ToString();
                    
                    rankChanges[i].ForeColor = Color.Red;
                    rankChanges[i].Text = $"-{change}";
                }
                else if (pointchange[i] > 0)
                {
                    //int checker = pointchange[i] * -1;
                    string change;
                    change = pointchange[i] <= 9 ? $"0{pointchange[i]}" : pointchange[i].ToString();

                    rankChanges[i].ForeColor = Color.LimeGreen;
                    rankChanges[i].Text = $"+{change}";
                }
                else
                {
                    rankChanges[i].ForeColor = Color.SlateGray;
                    rankChanges[i].Text = "0";
                }
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
