using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ComplitedTask
    {
        /// <summary>
        /// completed_at string
        /// </summary>
        [JsonPropertyName("completed_at")]
        public required DateTime CompletedAt { get; init; }

        /// <summary>
        /// task_id integer
        /// </summary>
        [JsonPropertyName("task_id")]
        public required int TaskId { get; init; }
    }
}
