using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesTask
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public required string Description { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public required string Name { get; init; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonProperty("notification")]
        public required string Notification { get; init; }

        /// <summary>
        /// task_id integer
        /// </summary>
        [JsonProperty("task_id")]
        public required int TaskId { get; init; }
    }
}
