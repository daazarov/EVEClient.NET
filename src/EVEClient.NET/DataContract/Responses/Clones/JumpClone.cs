using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class JumpClone
    {
        /// <summary>
        /// implant ids integer
        /// </summary>
        [JsonProperty("implants")]
        public int[] Implants { get; init; }

        /// <summary>
        /// jump_clone_id integer
        /// </summary>
        [JsonProperty("jump_clone_id")]
        public int JumpCloneId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonProperty("location_type")]
        public CloneLocationType LocationType { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }
    }
}
