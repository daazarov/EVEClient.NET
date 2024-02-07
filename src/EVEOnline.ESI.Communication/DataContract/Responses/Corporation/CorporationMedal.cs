using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CorporationMedal
    {
        /// <summary>
        /// created_at string
        /// </summary>
        [JsonProperty("created_at")]
        public DateTime CreatedAt {  get; set; }

        /// <summary>
        /// ID of the character who created this medal
        /// </summary>
        [JsonProperty("creator_id")]
        public int CreatorId { get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// medal_id integer
        /// </summary>
        [JsonProperty("medal_id")]
        public int MedalId { get; set; }

        /// <summary>
        /// title string
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
