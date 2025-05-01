using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Totals
    {
        [JsonPropertyName("last_week")]
        public required int LastWeek { get; init; }

        [JsonPropertyName("total")]
        public required int Total { get; init; }

        [JsonPropertyName("yesterday")]
        public required int Yesterday { get; init; }
    }
}
