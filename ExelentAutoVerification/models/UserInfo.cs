using Newtonsoft.Json;

namespace ExelentAutoVerify.Models
{
    public struct UserInfo
    {
        [JsonProperty("username")]
        public string Username                   { get; set; }

        [JsonProperty("balance")]
        public double Balance                    { get; set; }

        [JsonProperty("trade_url")]
        public string TradeUrl                   { get; set; }

        [JsonProperty("purchases")]
        public Purchase[] Purchases              { get; set; }

        [JsonProperty("hourboost_purchases")]
        public Purchase[] HourboostPurchases     { get; set; }

        [JsonProperty("market_purchases")]
        public MarketPurchase[] MarketPurchases  { get; set; }

        [JsonProperty("devices")]
        public Device[] Devices                  { get; set; }

        [JsonProperty("token")]
        public string Token                      { get; set; }

        internal void Login() {
            // LoginSystem.Run(token);
        }
    }
}
