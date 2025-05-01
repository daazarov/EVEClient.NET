using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class JumpClone
    {
        /// <summary>
        /// implant ids integer
        /// </summary>
        [JsonPropertyName("implants")]
        public required int[] Implants { get; init; }

        /// <summary>
        /// jump_clone_id integer
        /// </summary>
        [JsonPropertyName("jump_clone_id")]
        public required int JumpCloneId { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonPropertyName("location_type")]
        public required CloneLocationType LocationType { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }
    }
}
