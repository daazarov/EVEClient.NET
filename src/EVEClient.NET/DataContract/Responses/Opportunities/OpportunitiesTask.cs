using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesTask
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; init; }

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
        /// task_id integer
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; init; }
    }
}
