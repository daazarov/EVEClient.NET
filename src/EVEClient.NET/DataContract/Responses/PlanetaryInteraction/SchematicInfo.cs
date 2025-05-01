using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SchematicInfo
    {
        /// <summary>
        /// Time in seconds to process a run
        /// </summary>
        [JsonPropertyName("cycle_time")]
        public required int CycleTime { get; init; }

        /// <summary>
        /// schematic_name string
        /// </summary>
        [JsonPropertyName("schematic_name")]
        public required string Name { get; init; }
    }
}
