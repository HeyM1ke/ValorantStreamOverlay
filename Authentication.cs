using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RestSharp;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;

namespace ValorantStreamOverlay
{
    class Authentication
    {
        public static void GetAuthorization(CookieContainer jar)
        {
            string url = "https://auth.riotgames.com/api/v1/authorization";
            RestClient client = new RestClient(url)
            {
                CookieContainer = jar
            };

            RestRequest request = new RestRequest(Method.POST);
            string body = "{\"client_id\":\"play-valorant-web-prod\",\"nonce\":\"1\",\"redirect_uri\":\"https://playvalorant.com" + "\",\"response_type\":\"token id_token\",\"scope\":\"account openid\"}";
            request.AddJsonBody(body);
            client.Execute(request);
        }

        public static string Authenticate(CookieContainer cookie, string user, string pass)
        {
            string url = "https://auth.riotgames.com/api/v1/authorization";
            RestClient client = new RestClient(url)
            {
                CookieContainer = cookie
            };

            RestRequest request = new RestRequest(Method.PUT);
            var auth = new {
                type = "auth",
                username = user,
                password = pass
            };
            string body = JsonConvert.SerializeObject(auth);
            request.AddJsonBody(body);

            return client.Execute(request).Content;
        }
    }
}
