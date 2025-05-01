using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Wing
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonPropertyName("id")]
        public required long Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// squads array
        /// </summary>
        [JsonPropertyName("squads")]
        public required List<Squad> Squads { get; init; }
    }

    public class Squad
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// id integer
        /// </summary>
        [JsonPropertyName("id")]
        public required long Id { get; init; }
    }
}
