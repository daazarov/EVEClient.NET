using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class JumpClone
    {
        /// <summary>
        /// implant ids integer
        /// </summary>
        [JsonProperty("implants")]
        public int[] Implants { get; set; }

        /// <summary>
        /// jump_clone_id integer
        /// </summary>
        [JsonProperty("jump_clone_id")]
        public int JumpCloneId { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        /// <summary>
        /// location_type string
        /// </summary>
        [JsonProperty("location_type")]
        public CloneLocationType LocationType { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
