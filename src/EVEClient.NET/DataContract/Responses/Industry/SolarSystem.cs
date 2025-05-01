using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SolarSystem
    {
        /// <summary>
        /// cost_indices array
        /// </summary>
        [JsonPropertyName("cost_indices")]
        public required List<CostIndice> CostIndices { get; init; }

        /// <summary>
        /// solar_system_id integer
        /// </summary>
        [JsonPropertyName("solar_system_id")]
        public required int SolarSystemId { get; init; }
    }

    public class CostIndice
    {
        /// <summary>
        /// activity string
        /// </summary>
        [JsonPropertyName("activity")]
        public required SolarSystemActivity Activity { get; init; }

        /// <summary>
        /// cost_index number
        /// </summary>
        [JsonPropertyName("cost_index")]
        public required float CostIndex { get; init; }
    }
}
