using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SchematicInfo
    {
        /// <summary>
        /// Time in seconds to process a run
        /// </summary>
        [JsonProperty("cycle_time")]
        public int CycleTime { get; init; }

        /// <summary>
        /// schematic_name string
        /// </summary>
        [JsonProperty("schematic_name")]
        public string Name { get; init; }
    }
}
