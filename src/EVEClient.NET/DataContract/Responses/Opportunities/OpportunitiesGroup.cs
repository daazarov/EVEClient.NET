using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesGroup
    {
        /// <summary>
        /// The groups that are connected to this group on the opportunities map
        /// </summary>
        [JsonProperty("connected_groups")]
        public int[] ConnectedGroups {  get; set; }

        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// group_id integer
        /// </summary>
        [JsonProperty("group_id")]
        public int GroupId { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonProperty("notification")]
        public string Notification {  get; set; }

        /// <summary>
        /// Tasks need to complete for this group
        /// </summary>
        [JsonProperty("required_tasks")]
        public int[] RequiredTasks { get; set; }
    }
}
