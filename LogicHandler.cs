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
    class JConfig //for json serialisation 
    {
        public string username { get; set; }
        public string password { get; set; }
        public string region { get; set; }
        public string background_top { get; set; }
        public string background_bot { get; set; }
        public string background_games { get; set; }
        public string games_positive { get; set; }
        public int refreshtime { get; set; }
    }

     enum ChangeableColors
    {
        BackgroundTop,
        BackgroundBot,
        BackgroundGames,
        GamesPositive,
        GamesNegative
    }

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

        public static Dictionary<ChangeableColors, Color> availableColors;

        public static string background_top;
        public static string background_bot;
        public static string background_games;
        public static string games_positive;
        public static string games_negative;

        public static int refreshTimeinSeconds;
        public Timer relogTimer;
        public Timer pointTimer;

        public static ValorantOverStream ValorantOver;
        public  LogicHandler logic;
        public LogicHandler(ValorantOverStream instance)
        {
            logic = this;
            ValorantOver = instance;

            availableColors = new Dictionary<ChangeableColors, Color>();

            Trace.Write(referencesLoc);
            if (File.Exists(referencesLoc))
            {
                Trace.Write($"Config File Found, Performing Parsing");
            }
            else
            {
                MessageBox.Show(
                    "Config File not found within references folder. Please add a Valid Config file to refernce folder.");
                Environment.Exit(1);
            }

            Trace.Write("Reading Config");
            ReadConfig();
            Trace.Write("Attempting to Login");
            login();

            FillAvailableColorContainer();

            UpdateLatest();
            new RankDetection();

            StartPointRefresh();
            StartRELOGTimer();
        }

        static void ReadConfig()
        {
            try
            {
                //Experiment: Create JSON With code if no file is detected:

                /*if (!File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "references", "config.json")))
                {
                    Trace.Write("Creating Json File.");
                    JConfig configuration = new JConfig()
                    {
                        username = "USERNAMEHERE",
                        password = "PASSWORDHERE",
                        region = "na",
                        refreshtime = 10

                    };
                    File.WriteAllText((Path.Combine(Directory.GetCurrentDirectory(), "references", "config.json")), JsonConvert.SerializeObject(configuration));
                    MessageBox.Show(
                        "Config File was not detected, a config file was created and is in your refrences folder. Please fill out the config file.");
                    Environment.Exit(1);
                }*/
                
                
                StreamReader r =
                    new StreamReader(Path.Combine(Directory.GetCurrentDirectory(), "references", "config.json"));
                string json = r.ReadToEnd();
                // DEBUGGING IGNORE Console.WriteLine(json);
                var localJSON = JsonConvert.DeserializeObject(json);
                JToken localObj = JToken.FromObject(localJSON);
                username = localObj["username"].Value<string>();
                password = localObj["password"].Value<string>();
                region = localObj["region"].Value<string>();
                background_top = localObj["background_top"].Value<string>();
                background_bot = localObj["background_bot"].Value<string>();
                background_games = localObj["background_games"].Value<string>();
                games_positive = localObj["games_positive"].Value<string>();
                games_negative = localObj["games_negative"].Value<string>();
                refreshTimeinSeconds = localObj["refreshtime"].Value<int>();
                if (refreshTimeinSeconds <= 9)
                {
                    MessageBox.Show("Refresh Time is too low, please set refresh time to more than 10");
                    Environment.Exit(1);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void FillAvailableColorContainer()
        {
            try
            {
                availableColors.Add(ChangeableColors.BackgroundTop, ColorTranslator.FromHtml(background_top));
                availableColors.Add(ChangeableColors.BackgroundBot, ColorTranslator.FromHtml(background_bot));
                availableColors.Add(ChangeableColors.BackgroundGames, ColorTranslator.FromHtml(background_games));
                availableColors.Add(ChangeableColors.GamesPositive, ColorTranslator.FromHtml(games_positive));
                availableColors.Add(ChangeableColors.GamesNegative, ColorTranslator.FromHtml(games_negative));
            }
            catch
            {
                //HTML color wrong
                MessageBox.Show("At least one of your colors has a typo.");
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
            catch (Exception e)
            {
                MessageBox.Show("Your Login was invalid, please check your Config File.");
                Environment.Exit(1);
            }
        }



        void UpdateLatest()
        {
            Trace.Write("UPDATING");
            //var test = Task.Run(() => PingCompApiAsync());
            dynamic response = GetCompApiAsync().GetAwaiter().GetResult();
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
            SetChangesToOverlay(points);
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



        private Color GetColor(ChangeableColors color)
        {
            return availableColors.GetValueOrDefault(color);
        }

        private void SetChangesToOverlay(int[] pointchange)
        {

            Label[] rankChanges = { ValorantOver.recentGame1, ValorantOver.recentGame2, ValorantOver.recentGame3 };

            ((Panel)ValorantOver.backgroundBot).BackColor = GetColor(ChangeableColors.BackgroundBot);
            ((Panel)ValorantOver.backgroundTop).BackColor = GetColor(ChangeableColors.BackgroundTop);


            for (int i = 0; i < pointchange.Length; i++)
            {
                rankChanges[i].BackColor = GetColor(ChangeableColors.BackgroundGames);
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
                    
                    rankChanges[i].ForeColor = GetColor(ChangeableColors.GamesNegative);
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

                    rankChanges[i].ForeColor = GetColor(ChangeableColors.GamesPositive);
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
            UpdateLatest();
            new RankDetection();
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
