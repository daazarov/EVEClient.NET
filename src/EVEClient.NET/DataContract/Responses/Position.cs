using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Position
    {
        /// <summary>
        /// x number
        /// </summary>
        [JsonPropertyName("x")]
        public required double X { get; init; }

        /// <summary>
        /// y number
        /// </summary>
        [JsonPropertyName("y")]
        public required double Y { get; init; }

        /// <summary>
        /// z number
        /// </summary>
        [JsonPropertyName("z")]
        public required double Z { get; init; }
    }
}
