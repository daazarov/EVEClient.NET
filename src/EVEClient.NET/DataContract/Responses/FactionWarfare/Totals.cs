using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Totals
    {
        [JsonProperty("last_week")]
        public int LastWeek { get; init; }

        [JsonProperty("total")]
        public int Total { get; init; }

        [JsonProperty("yesterday")]
        public int Yesterday { get; init; }
    }
}
