using Newtonsoft.Json;
using static ExelentAutoVerification.services.App;

namespace ExelentAutoVerification.Requests
{
    public struct VerificationRequest
    {
        [JsonProperty("send_discord")]
        public bool SendDiscord { get; set; }

        [JsonProperty("current_app")]
        public CurrentAPP CurrentApp { get; set; }
    }
}