using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Extraction
    {
        /// <summary>
        /// The time at which the chunk being extracted will arrive and can be fractured by the moon mining drill.
        /// </summary>
        [JsonProperty("chunk_arrival_time")]
        public required DateTime ChunkArrivalTime { get; init; }

        /// <summary>
        /// The time at which the current extraction was initiated.
        /// </summary>
        [JsonProperty("extraction_start_time")]
        public required DateTime ExtractionStartTime { get; init; }

        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonProperty("moon_id")]
        public required int MoonId { get; init; }

        /// <summary>
        /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill.
        /// </summary>
        [JsonProperty("natural_decay_time")]
        public required DateTime NaturalDecayTime { get; init; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonProperty("structure_id")]
        public required long StructureId { get; init; }
    }
}
