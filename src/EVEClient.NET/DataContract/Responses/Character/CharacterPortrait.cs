using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterPortrait
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
        /// px512x512 string
        /// </summary>
        [JsonPropertyName("px512x512")]
        public string? px512x512 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonPropertyName("px64x64")]
        public string? px64x64 { get; init; }
    }
}
