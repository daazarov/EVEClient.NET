﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Totals
    {
        [JsonProperty("last_week")]
        public int LastWeek { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("yesterday")]
        public int Yesterday { get; set; }
    }
}
