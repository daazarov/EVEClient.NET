using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Extraction
    {
        /// <summary>
        /// The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill.
        /// </summary>
        [JsonPropertyName("chunk_arrival_time")]
        public required DateTime ChunkArrivalTime { get; init; }

        /// <summary>
        /// The time at which the current extraction was initiated.
        /// </summary>
        [JsonPropertyName("extraction_start_time")]
        public required DateTime ExtractionStartTime { get; init; }

        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonPropertyName("moon_id")]
        public required int MoonId { get; init; }

        /// <summary>
        /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill.
        /// </summary>
        [JsonPropertyName("natural_decay_time")]
        public required DateTime NaturalDecayTime { get; init; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonPropertyName("structure_id")]
        public required long StructureId { get; init; }
    }
}
