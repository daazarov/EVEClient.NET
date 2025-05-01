using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Insurance
    {
        /// <summary>
        /// A list of a available insurance levels for this ship type
        /// </summary>
        [JsonPropertyName("levels")]
        public required List<Levels> Levels { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }

    public class Levels
    {
        /// <summary>
        /// cost number
        /// </summary>
        [JsonPropertyName("cost")]
        public required float Cost { get; init; }

        /// <summary>
        /// Localized insurance level
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// payout number
        /// </summary>
        [JsonPropertyName("payout")]
        public required float Payout { get; init; }
    }
}
