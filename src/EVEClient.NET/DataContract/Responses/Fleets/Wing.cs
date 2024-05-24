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
        public long Id {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// squads array
        /// </summary>
        [JsonProperty("squads")]
        public List<Squad> Squads { get; set; } = new List<Squad>();
    }

    public class Squad
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// id integer
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
