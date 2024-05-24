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
        public DateTime ChunkArrivalTime { get; set; }

        /// <summary>
        /// The time at which the current extraction was initiated.
        /// </summary>
        [JsonProperty("extraction_start_time")]
        public DateTime ExtractionStartTime { get; set; }

        /// <summary>
        /// moon_id integer
        /// </summary>
        [JsonProperty("moon_id")]
        public int MoonId { get; set; }

        /// <summary>
        /// The time at which the chunk being extracted will naturally fracture if it is not first fractured by the moon mining drill.
        /// </summary>
        [JsonProperty("natural_decay_time")]
        public DateTime NaturalDecayTime { get; set; }

        /// <summary>
        /// structure_id integer
        /// </summary>
        [JsonProperty("structure_id")]
        public long StructureId { get; set; }
    }
}
