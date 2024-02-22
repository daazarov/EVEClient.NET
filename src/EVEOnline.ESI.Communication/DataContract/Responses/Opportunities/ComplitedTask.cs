using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class ComplitedTask
    {
        /// <summary>
        /// completed_at string
        /// </summary>
        [JsonProperty("completed_at")]
        public DateTime CompletedAt {  get; set; }

        /// <summary>
        /// task_id integer
        /// </summary>
        [JsonProperty("task_id")]
        public int TaskId { get; set; }
    }
}
