﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ContactLabel
    {
        /// <summary>
        /// label_id integer
        /// </summary>
        [JsonProperty("label_id")]
        public long LabelId { get; set; }

        /// <summary>
        /// label_name string
        /// </summary>
        [JsonProperty("label_name")]
        public string LabelName { get; set; }
    }
}
