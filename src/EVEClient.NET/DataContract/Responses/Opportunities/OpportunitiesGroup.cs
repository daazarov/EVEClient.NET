using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesGroup
    {
        /// <summary>
        /// The groups that are connected to this group on the opportunities map
        /// </summary>
        [JsonProperty("connected_groups")]
        public required int[] ConnectedGroups {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public required int GroupId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonProperty("notification")]
        public required string Notification {  get; set; }

        /// <summary>
        /// Tasks need to complete for this group
        /// </summary>
        [JsonProperty("required_tasks")]
        public required int[] RequiredTasks { get; init; }
    }
}
