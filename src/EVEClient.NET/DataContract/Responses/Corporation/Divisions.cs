using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Divisions
    {
        /// <summary>
        /// hangar array
        /// </summary>
        [JsonProperty("hangar")]
        public List<Division> Hangar {  get; set; }

        /// <summary>
        /// wallet array
        /// </summary>
        [JsonProperty("wallet")]
        public List<Division> Wallet { get; set; }
    }

    public class Division
    {
        /// <summary>
        /// division integer
        /// </summary>
        [JsonProperty("division")]
        public int? DivisionId {  get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
