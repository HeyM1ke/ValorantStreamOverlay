using System;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
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
                compRequest.AddHeader("X-Riot-ClientPlatform",
                    "ew0KCSJwbGF0Zm9ybVR5cGUiOiAiUEMiLA0KCSJwbGF0Zm9ybU9TIjogIldpbmRvd3MiLA0KCSJwbGF0Zm9ybU9TVmVyc2lvbiI6ICIxMC4wLjE5MDQyLjEuMjU2LjY0Yml0IiwNCgkicGxhdGZvcm1DaGlwc2V0IjogIlVua25vd24iDQp9");

                IRestResponse rankedResp = compRank.Get(compRequest);

                Trace.WriteLine(rankedResp.Content);
                if (rankedResp.IsSuccessful)
                {
                    dynamic jsonconvert = JsonConvert.DeserializeObject<JObject>(rankedResp.Content);

                    dynamic matches = jsonconvert["Matches"];

                    foreach (var game in matches)
                    {
                        if (game["RankedRatingAfterUpdate"] != 0)
                        {
                            currentRP = game["RankedRatingAfterUpdate"];
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

            LogicHandler.ValorantOver.rankPointsElo.Text =
                $"{currentRP} RR | {(rankNumber * 100) - 300 + currentRP} TRR";

            LogicHandler.currentMMRorELO = (rankNumber * 100) - 300 + currentRP;
            LogicHandler.currentRankPoints = currentRP;
        }

       
    }
}
