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
        private static string referencesLoc =
            Path.Combine(Directory.GetCurrentDirectory(), "references", "config.json");

        public static string AccessToken { get; set; }
        public static string EntitlementToken { get; set; }
        public static string UserID { get; set; }

        public static string username;
        public static string password;
        public static string region;
        public static string language;
        public static int skin;
        public static int refreshTimeinSeconds;
        public Timer relogTimer;
        public Timer pointTimer;

        public static ValorantOverStream ValorantOver;
        public  LogicHandler logic;
        public RankDetection rankDetect;
        public LogicHandler(ValorantOverStream instance)
        {
            logic = this;
            ValorantOver = instance;

            Trace.Write("Reading Settings");
            ReadSettings();
            //Login now attempts when reading settings.
            Trace.Write("Attempting to Login");
            /*login();

            UpdateLatest();
            new RankDetection();

            StartPointRefresh();
            StartRELOGTimer();*/
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
                
                
                login();

                UpdateLatest();
                StartPointRefresh();
                StartRELOGTimer();

                if (language == "es")
                {
                    new RankDetecionES();

                }

                if (language == "en")
                {
                    new RankDetection();

                }

                if (language == "fr")
                {
                    new RankDetecionFR();
                }
            }

        }


        void login()
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



        async Task UpdateLatest()
        {
            Trace.Write("UPDATING");
            //var test = Task.Run(() => PingCompApiAsync());
            dynamic response = GetCompApiAsync().GetAwaiter().GetResult();
            if (response == null)
            {

            }
            else
            {
                dynamic matches = response["Matches"];
                //parseResponse(matches);
                Trace.Write("Checkpoint 1");
                int[] points = new int[3];

                dynamic test = matches;
                Console.WriteLine(test);
                int count = 0;
                int i = 0;
                foreach (var game in test)
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
                        int differ = (after - before) + 100; // positive num
                        points[i++] = differ;
                        count++;
                    }
                    else if (game["CompetitiveMovement"] == "DEMOTED")
                    {
                        // player demoted
                        int before = game["TierProgressBeforeUpdate"];
                        int after = game["TierProgressAfterUpdate"];
                        int differ = (after - before) - 100; // negative num
                        points[i++] = differ;
                        count++;
                    }
                    else
                    {
                        int before = game["TierProgressBeforeUpdate"];
                        int after = game["TierProgressAfterUpdate"];
                        points[i++] = after - before;
                        // If a change is detected
                        // if a change is detected, then add number difference between the after - the before to an array
                        // that contains 3 values, 3 values are then sent to SetChangesToOverlay(array here <--- )
                        // at the limit of 3, run loop, til array hits 3 containing values. then send array.
                        count++;
                    }

                    if (count >= 3) // 3 recent matches found
                        break;
                }
                Trace.Write("Checkpoint 2");
                SetChangesToOverlay(points).GetAwaiter();
            }
            
        }


        //Testing:

        private async Task<JObject> GetCompApiAsync()
        {
            
            IRestClient compClient = new RestClient(new Uri($"https://pd.{region}.a.pvp.net/mmr/v1/players/{UserID}/competitiveupdates?startIndex=0&endIndex=20"));
            RestRequest compRequest = new RestRequest(Method.GET);

            compRequest.AddHeader("Authorization", $"Bearer {AccessToken}");
            compRequest.AddHeader("X-Riot-Entitlements-JWT", EntitlementToken);

            IRestResponse rankedResp = compClient.Get(compRequest);

            return rankedResp.IsSuccessful ? JsonConvert.DeserializeObject<JObject>(rankedResp.Content) : null;
        }

        /*private void parseResponse(JObject response)
        {
            int[] points = new int[3];

            dynamic test = response;

            int count = 0;
            int i = 0;
            foreach (var game in test)
            {
                if (game["CompetitiveMovement"] == "MOVEMENT_UNKNOWN")
                {
                    // not a ranked game; 
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
                    points[i++] = before - after;
                    // If a change is detected
                    // if a change is detected, then add number difference between the after - the before to an array
                    // that contains 3 values, 3 values are then sent to SetChangesToOverlay(array here <--- )
                    // at the limit of 3, run loop, til array hits 3 containing values. then send array.
                    count++;
                }

                if (count >= 3) // 3 recent matches found
                    break;
            }
            //Need to add login :)
            SetChangesToOverlay(points);
        }*/

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
                    if (pointchange[i] <= 9)
                    {
                        change = $"0{pointchange[i]}";
                    }
                    else
                    {
                        change = pointchange[i].ToString();
                    }
                    
                    rankChanges[i].ForeColor = Color.Red;
                    rankChanges[i].Text = $"-{change}";
                }
                else if (pointchange[i] > 0)
                {
                    //int checker = pointchange[i] * -1;
                    string change;
                    if (pointchange[i] <= 9)
                    {
                        change = $"0{pointchange[i]}";
                    }
                    else
                    {
                        change = pointchange[i].ToString();
                    }

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
            UpdateLatest().GetAwaiter();

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
            login();
            pointTimer.Start();
        }


    }
}
