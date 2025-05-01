using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesGroup
    {
        /// <summary>
        /// The groups that are connected to this group on the opportunities map
        /// </summary>
        [JsonPropertyName("connected_groups")]
        public required int[] ConnectedGroups { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonPropertyName("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonPropertyName("notification")]
        public required string Notification { get; init; }

        /// <summary>
        /// Tasks need to complete for this group
        /// </summary>
        [JsonPropertyName("required_tasks")]
        public required int[] RequiredTasks { get; init; }
    }
}
