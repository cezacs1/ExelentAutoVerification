using Newtonsoft.Json;

namespace ExelentAutoVerification.Models
{
    public struct Purchase
    {
        [JsonProperty("product_id")]
        public string ProductId    { get; set; }

        [JsonProperty("product_name")]
        public string ProductName  { get; set; }

        [JsonProperty("price")]
        public double Price        { get; set; }

        [JsonProperty("expires_at")]
        public string ExpiresAt    { get; set; }

        [JsonProperty("purchased_at")]
        public string PurchasedAt  { get; set; }
    }
}
