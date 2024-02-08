﻿using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Observer
    {
        /// <summary>
        /// last_updated string
        /// </summary>
        [JsonProperty("last_updated")]
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// The entity that was observing the asteroid field when it was mined.
        /// </summary>
        [JsonProperty("observer_id")]
        public long ObserverId { get; set; }

        /// <summary>
        /// The category of the observing entity
        /// </summary>
        [JsonProperty("observer_type")]
        public string ObserverType { get; set; }
    }
}
