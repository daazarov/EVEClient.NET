using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Totals
    {
        [JsonProperty("last_week")]
        public required int LastWeek { get; init; }

        [JsonProperty("total")]
        public required int Total { get; init; }

        [JsonProperty("yesterday")]
        public required int Yesterday { get; init; }
    }
}
