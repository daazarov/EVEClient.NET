﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AllianceIcon
    {
        /// <summary>
        /// px128x128 string
        /// </summary>
        [JsonProperty("px128x128")]
        public required string px128x128 { get; init; }

        /// <summary>
        /// px64x64 string
        /// </summary>
        [JsonProperty("px64x64")]
        public required string px64x64 { get; init; }
    }
}
