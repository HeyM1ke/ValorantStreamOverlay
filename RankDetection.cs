using System;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ValorantStreamOverlay
{
    class RankDetection
    {
        public static dynamic rankJson;
        public static int currentRP;
        public static string rankName;
        public RankDetection()
        {
            //Start Update
            GetCloudRankJSON().GetAwaiter().GetResult();
            int rankNum = UPDATECompRankAsync().GetAwaiter().GetResult();
            RankParser(rankNum);
            
        }

        public void UpdateRank()
        {
            int rankNum = UPDATECompRankAsync().GetAwaiter().GetResult();
            RankParser(rankNum);
        }

        private async Task<int> UPDATECompRankAsync()
        {
            try
            {
                IRestClient compRank = new RestClient(new Uri(
                    $"https://pd.{LogicHandler.region}.a.pvp.net/mmr/v1/players/{LogicHandler.UserID}/competitiveupdates?startIndex=0&endIndex=20"));
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
            catch (Exception e)
            {
                MessageBox.Show("Error Retrieving UPDATECompRankAsync function");
                return 0;
            }

        }

        private async Task GetCloudRankJSON()
        {
            IRestClient cloudRankJson = new RestClient(new Uri("https://502.wtf/ValorrankInfo.json"));
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
            rankName = rankNameLower.ToUpper();


            Trace.Write("Setting Rank To Valid Rank Num");

            LogicHandler.ValorantOver.rankingLabel.Text = rankName;

            var resource = Properties.Resources.ResourceManager.GetObject("TX_CompetitiveTier_Large_" + rankNumber);
            Bitmap myImage = (Bitmap)resource;
            LogicHandler.ValorantOver.rankIconBox.Image = myImage;

            if (rankNumber > 3) {
                LogicHandler.ValorantOver.rankPointsElo.Text =
                    $"{currentRP} RP | {(rankNumber * 100) - 300 + currentRP} ELO";
                LogicHandler.currentMMRorELO = (rankNumber * 100) - 300 + currentRP;
            }
            else {
                LogicHandler.ValorantOver.rankPointsElo.Text =
                    $"{currentRP} RP | 0 ELO";
                LogicHandler.currentMMRorELO = 0;
            }
            LogicHandler.currentRankPoints = currentRP;
        }

       
    }
}
