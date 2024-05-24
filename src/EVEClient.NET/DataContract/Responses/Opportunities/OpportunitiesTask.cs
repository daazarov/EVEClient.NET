using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesTask
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// notification string
        /// </summary>
        [JsonProperty("notification")]
        public string Notification { get; set; }

        /// <summary>
        /// task_id integer
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}
