using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class OpportunitiesTask
    {
        /// <summary>
        /// description string
        /// </summary>
        [JsonPropertyName("description")]
        public required string Description { get; init; }

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
        /// task_id integer
        /// </summary>
        [JsonPropertyName("task_id")]
        public required int TaskId { get; init; }
    }
}
