using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStreamOverlay
{
    class RankDetection
    {
        List<string> rankNames = new List<string>();
        private dynamic rankJson;
        private int currentRP;
        public RankDetection()
        {
            //Start Update
            int rankNum = UPDATECompRankAsync().GetAwaiter().GetResult();
            GetCloudRankJSON().GetAwaiter().GetResult();
            RankParser(rankNum);
        }

        private async Task<int> UPDATECompRankAsync()
        {
            
            IRestClient compRank = new RestClient(new Uri($"https://pd.{LogicHandler.region}.a.pvp.net/mmr/v1/players/{LogicHandler.UserID}/competitiveupdates?startIndex=0&endIndex=20"));
            IRestRequest compRequest = new RestRequest(Method.GET);
            compRequest.AddHeader("Authorization", $"Bearer {LogicHandler.AccessToken}");
            compRequest.AddHeader("X-Riot-Entitlements-JWT", LogicHandler.EntitlementToken);

            IRestResponse rankedResp = compRank.Get(compRequest);

            if (rankedResp.IsSuccessful)
            {
                dynamic jsonconvert = JsonConvert.DeserializeObject<JObject>(rankedResp.Content);

                dynamic matches = jsonconvert["Matches"];

                foreach (var game in matches)
                {
                    if (game["CompetitiveMovement"] != "MOVEMENT_UNKNOWN")
                    {
                        currentRP = game["TierProgressAfterUpdate"];
                        return game["TierAfterUpdate"];
                    }
                }
                return 0;
            }

            return 0;
        }

        private async Task GetCloudRankJSON()
        {
            IRestClient cloudRankJson = new RestClient(new Uri("https://502.wtf/rankInfo.json"));
            IRestRequest rankRequest = new RestRequest(Method.GET);
            IRestResponse rankResp = cloudRankJson.Get(rankRequest);
            rankJson = (rankResp.IsSuccessful) ? rankJson = rankResp.Content : rankJson = string.Empty;
        }
        void RankParser(int rankNumber)
        {
            //Getting Errors when trying to pull the Json Data.
            
            var cloudJsonDeserial = JsonConvert.DeserializeObject(rankJson);
            JToken cloudJson = JToken.FromObject(cloudJsonDeserial);
            string rankNameLower = cloudJson["Ranks"][rankNumber.ToString()].Value<string>();
            string rankNameALPHA = rankNameLower.ToUpper();


            Trace.Write("Setting Rank To Valid Rank Num");

            LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;

            var resource = Properties.Resources.ResourceManager.GetObject("TX_CompetitiveTier_Large_" + rankNumber);
            Bitmap myImage = (Bitmap)resource;
            LogicHandler.ValorantOver.rankIconBox.Image = myImage;

            LogicHandler.ValorantOver.rankPointsElo.Text =
                $"{currentRP} RP | {(rankNumber * 100) - 300 + currentRP} ELO";


            /*switch (rankNumber)
            {
                case (0):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_0;
                    break;
                case (1):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_1;
                    break;
                case (2):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_2;
                    break;
                case (3):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_3;
                    break;
                case (4):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_4;
                    break;
                case (5):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_5;
                    break;
                case (6):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_6;
                    break;
                case (7):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_7;
                    break;
                case (8):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_8;
                    break;
                case (9):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_9;
                    break;
                case (10):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_10;
                    break;
                case (11):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_11;
                    break;
                case (12):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_12;
                    break;
                case (13):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_13;
                    break;
                case (14):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_14;
                    break;
                case (15):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_15;
                    break;
                case (16):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_16;
                    break;
                case (17):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_17;
                    break;
                case (18):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_18;
                    break;
                case (19):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_19;
                    break;
                case (20):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_20;
                    break;
                case (21):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_21;
                    break;
                case (22):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_22;
                    break;
                case (23):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_23;
                    break;
                case (24):
                    LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;
                    LogicHandler.ValorantOver.rankIconBox.Image = Properties.Resources.TX_CompetitiveTier_Large_24;
                    break;

            }*/
        }

       
    }
    
    class RankDetecionES
    {
        List<string> rankNames = new List<string>();
        private dynamic rankJson;
        private int currentRP;
        public RankDetecionES()
        {
            //Start Update
            int rankNum = UPDATECompRankAsync().GetAwaiter().GetResult();
            GetCloudRankJSON().GetAwaiter().GetResult();
            RankParser(rankNum);
        }

        private async Task<int> UPDATECompRankAsync()
        {

            IRestClient compRank = new RestClient(new Uri($"https://pd.{LogicHandler.region}.a.pvp.net/mmr/v1/players/{LogicHandler.UserID}/competitiveupdates?startIndex=0&endIndex=20"));
            IRestRequest compRequest = new RestRequest(Method.GET);
            compRequest.AddHeader("Authorization", $"Bearer {LogicHandler.AccessToken}");
            compRequest.AddHeader("X-Riot-Entitlements-JWT", LogicHandler.EntitlementToken);

            IRestResponse rankedResp = compRank.Get(compRequest);

            if (rankedResp.IsSuccessful)
            {
                dynamic jsonconvert = JsonConvert.DeserializeObject<JObject>(rankedResp.Content);

                dynamic matches = jsonconvert["Matches"];

                foreach (var game in matches)
                {
                    if (game["CompetitiveMovement"] != "MOVEMENT_UNKNOWN")
                    {
                        currentRP = game["TierProgressAfterUpdate"];
                        return game["TierAfterUpdate"];
                    }
                }
                return 0;
            }

            return 0;
        }

        private async Task GetCloudRankJSON()
        {
            IRestClient cloudRankJson = new RestClient(new Uri("https://raw.githubusercontent.com/BobbyESP/ValorantStreamOverlay/main/rankInfo-es.json"));
            IRestRequest rankRequest = new RestRequest(Method.GET);
            IRestResponse rankResp = cloudRankJson.Get(rankRequest);
            rankJson = (rankResp.IsSuccessful) ? rankJson = rankResp.Content : rankJson = string.Empty;
        }
        void RankParser(int rankNumber)
        {
            //Getting Errors when trying to pull the Json Data.

            var cloudJsonDeserial = JsonConvert.DeserializeObject(rankJson);
            JToken cloudJson = JToken.FromObject(cloudJsonDeserial);
            string rankNameLower = cloudJson["Ranks"][rankNumber.ToString()].Value<string>();
            string rankNameALPHA = rankNameLower.ToUpper();


            Trace.Write("Setting Rank To Valid Rank Num");

            LogicHandler.ValorantOver.rankingLabel.Text = rankNameALPHA;

            var resource = Properties.Resources.ResourceManager.GetObject("TX_CompetitiveTier_Large_" + rankNumber);
            Bitmap myImage = (Bitmap)resource;
            LogicHandler.ValorantOver.rankIconBox.Image = myImage;

            LogicHandler.ValorantOver.rankPointsElo.Text =
                $"{currentRP} RP | {(rankNumber * 100) - 300 + currentRP} ELO";
        }



        }
    }
