using ExelentAutoVerification.Models;
using ExelentAutoVerification.Requests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Text;

namespace ExelentAutoVerification.services
{
    public class AutoVerification : App
    {
        private const string BaseUrl = "https://exsensical.win/autoverification.php";
        // another url:                "https://exelent.vip/autoverification.php"

        public AutoVerification(string procName) : base(procName) { }

        public UserInfo? Verify()
        {
            try
            {
                string json = SendRequest();
                JObject obj = JObject.Parse(json);
                if (obj["success"]?.Value<bool>() != true)
                {
                    string error = obj["error"]?.Value<string>();
                    Console.WriteLine(string.IsNullOrEmpty(error) ? "Doðrulama baþarýsýz." : "Hata: " + error);
                    return null;
                }
                return JsonConvert.DeserializeObject<UserInfo>(json);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Hata: " + ex.Message);
                return null;
            }
        }

        private string SendRequest()
        {
            using (var client = new HttpClient())
            {
                var request = new VerificationRequest
                {
                    CurrentApp = this.currentApp,
                    // discord bildirim parametresi kaldýrýldý, artýk serverside..
                };

                var payload = new StringContent(
                    JsonConvert.SerializeObject(request),
                    Encoding.UTF8, "application/json");
                var response = client.PostAsync(BaseUrl, payload).Result;
                return response.Content.ReadAsStringAsync().Result;
            }
        }
    }
}