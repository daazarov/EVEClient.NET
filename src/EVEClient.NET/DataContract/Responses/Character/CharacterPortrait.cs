using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterPortrait
    {
        /// <summary>
        /// px128x128 string
        /// </summary>
        [JsonProperty("px128x128")]
        public string? px128x128 {  get; set; }

        /// <summary>
        /// px256x256 string
        /// </summary>
        [JsonProperty("px256x256")]
        public string? px256x256 { get; init; }

        /// <summary>
        /// px512x512 string
        /// </summary>
        [JsonProperty("px512x512")]
        public string? px512x512 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonProperty("px64x64")]
        public string? px64x64 { get; init; }
    }
}
