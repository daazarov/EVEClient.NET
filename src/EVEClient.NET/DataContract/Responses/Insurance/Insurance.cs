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
        public List<Levels> Levels { get; set; } = new List<Levels>();

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }

    public class Levels
    {
        /// <summary>
        /// cost number
        /// </summary>
        [JsonProperty("cost")]
        public float Cost { get; set; }

        /// <summary>
        /// Localized insurance level
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// payout number
        /// </summary>
        [JsonProperty("payout")]
        public float Payout { get; set; }
    }
}
