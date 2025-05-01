using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class LabelCounts
    {
        /// <summary>
        /// labels array
        /// </summary>
        [JsonPropertyName("labels")]
        public List<Label>? Labels { get; init; }

        /// <summary>
        /// total_unread_count integer
        /// </summary>
        [JsonPropertyName("total_unread_count")]
        public int? TotalUnreadCount { get; init; }
    }

    public class Label
    {
        /// <summary>
        /// color string
        /// </summary>
        [JsonPropertyName("color")]
        public LabelColor? Color { get; init; }

        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonPropertyName("label_id")]
        public int? LabelId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; init; }

        /// <summary>
        /// unread_count integer
        /// </summary>
        [JsonPropertyName("unread_count")]
        public int? UnreadCount { get; init; }
    }
}
