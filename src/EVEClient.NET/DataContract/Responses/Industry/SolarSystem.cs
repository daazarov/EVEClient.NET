using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SolarSystem
    {
        /// <summary>
        /// cost_indices array
        /// </summary>
        [JsonProperty("cost_indices")]
        public List<CostIndice> CostIndices { get; set; } = new List<CostIndice>();

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }
    }

    public class CostIndice
    {
        /// <summary>
        /// activity string
        /// </summary>
        [JsonProperty("activity")]
        public SolarSystemActivity Activity { get; set; }

        /// <summary>
        /// cost_index number
        /// </summary>
        [JsonProperty("cost_index")]
        public float CostIndex { get; set; }
    }
}
