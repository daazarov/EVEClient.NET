using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class AllianceIcon
    {
        /// <summary>
        /// px128x128 string
        /// </summary>
        [JsonPropertyName("px128x128")]
        public required string px128x128 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonPropertyName("px64x64")]
        public required string px64x64 { get; init; }
    }
}
