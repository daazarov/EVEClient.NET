using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class LabelCounts
    {
        /// <summary>
        /// labels array
        /// </summary>
        [JsonProperty("labels")]
        public List<Label> Labels { get; set; }

        /// <summary>
        /// total_unread_count integer
        /// </summary>
        [JsonProperty("total_unread_count")]
        public int TotalUnreadCount { get; set; }
    }

    public class Label
    {
        /// <summary>
        /// color string
        /// </summary>
        [JsonProperty("color")]
        public LabelColor Color { get; set; } = LabelColor.White;

        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonProperty("label_id")]
        public int? LabelId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// unread_count integer
        /// </summary>
        [JsonProperty("unread_count")]
        public int? UnreadCount { get; set; }
    }
}
