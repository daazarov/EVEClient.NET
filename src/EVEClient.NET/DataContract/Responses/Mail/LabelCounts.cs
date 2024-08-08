using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class LabelCounts
    {
        /// <summary>
        /// labels array
        /// </summary>
        [JsonProperty("labels")]
        public List<Label>? Labels { get; init; }

        /// <summary>
        /// total_unread_count integer
        /// </summary>
        [JsonProperty("total_unread_count")]
        public int? TotalUnreadCount { get; init; }
    }

    public class Label
    {
        /// <summary>
        /// color string
        /// </summary>
        [JsonProperty("color")]
        public LabelColor? Color { get; init; }

        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonProperty("label_id")]
        public int? LabelId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// unread_count integer
        /// </summary>
        [JsonProperty("unread_count")]
        public int? UnreadCount { get; init; }
    }
}
