using Newtonsoft.Json;

namespace ExelentAutoVerification.Models
{
    public struct Device
    {
        [JsonProperty("os")]
        public string Os           { get; set; }

        [JsonProperty("cpu_cores")]
        public int CpuCores        { get; set; }

        [JsonProperty("ram_gb")]
        public double RamGb        { get; set; }

        [JsonProperty("gpu")]
        public string Gpu          { get; set; }

        [JsonProperty("timezone")]
        public string Timezone     { get; set; }

        [JsonProperty("last_login")]
        public string LastLogin    { get; set; }

        [JsonProperty("ip")]
        public string Ip           { get; set; }
    }
}
