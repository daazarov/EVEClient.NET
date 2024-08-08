using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesGroup
    {
        /// <summary>
        /// The groups that are connected to this group on the opportunities map
        /// </summary>
        [JsonProperty("connected_groups")]
        public int[] ConnectedGroups { get; init; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; init; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; init; }

        /// <summary>
        /// Tasks need to complete for this group
        /// </summary>
        [JsonProperty("required_tasks")]
        public int[] RequiredTasks { get; init; }
    }
}
