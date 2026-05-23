using System;
using System.Net.Http;
using ExelentAutoVerify.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace ExelentAutoVerify.Services
{
    public static class AutoVerification
    {
        private const string Url = "https://exelent.vip/autoverification.php";
        // "https://exsensical.win/autoverification.php"

        public static UserInfo? Verify()
        {
            try
            {
                using (var client = new HttpClient())
                {
                    string json = client.GetStringAsync(Url).Result;
                    JObject obj = JObject.Parse(json);

                    if (obj["success"]?.Value<bool>() != true) return null;

                    return JsonConvert.DeserializeObject<UserInfo>(json);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return null;
            }
        }
    }
}
