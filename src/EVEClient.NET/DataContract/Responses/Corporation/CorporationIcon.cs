using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CorporationIcon
    {
        /// <summary>
        /// px128x128 string
        /// </summary>
        [JsonPropertyName("px128x128")]
        public string? px128x128 { get; init; }

        /// <summary>
        /// px256x256 string
        /// </summary>
        [JsonPropertyName("px256x256")]
        public string? px256x256 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonPropertyName("px64x64")]
        public string? px64x64 { get; init; }
    }
}
