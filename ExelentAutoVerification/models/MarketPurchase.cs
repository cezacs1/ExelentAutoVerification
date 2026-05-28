using Newtonsoft.Json;

namespace ExelentAutoVerification.Models
{
    public struct MarketPurchase
    {
        [JsonProperty("item_id")]
        public string ItemId       { get; set; }

        [JsonProperty("item_name")]
        public string ItemName     { get; set; }

        [JsonProperty("item_type")]
        public string ItemType     { get; set; }

        [JsonProperty("quantity")]
        public int Quantity        { get; set; }

        [JsonProperty("unit_price")]
        public double UnitPrice    { get; set; }

        [JsonProperty("total_price")]
        public double TotalPrice   { get; set; }

        [JsonProperty("trade_url")]
        public string TradeUrl     { get; set; }

        [JsonProperty("purchased_at")]
        public string PurchasedAt  { get; set; }
    }
}
