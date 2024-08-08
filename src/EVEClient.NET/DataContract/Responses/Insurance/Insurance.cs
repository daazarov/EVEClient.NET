using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Insurance
    {
        /// <summary>
        /// A list of a available insurance levels for this ship type
        /// </summary>
        [JsonProperty("levels")]
        public List<Levels> Levels { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; init; }
    }

    public class Levels
    {
        /// <summary>
        /// cost number
        /// </summary>
        [JsonProperty("cost")]
        public float Cost { get; init; }

        /// <summary>
        /// Localized insurance level
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// payout number
        /// </summary>
        [JsonProperty("payout")]
        public float Payout { get; init; }
    }
}
