using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Wing
    {
        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public required long Id { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// squads array
        /// </summary>
        [JsonProperty("squads")]
        public required List<Squad> Squads { get; init; }
    }

    public class Squad
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public required long Id { get; init; }
    }
}
