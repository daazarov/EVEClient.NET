﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Coordinates
    {
        /// <summary>
        /// x number
        /// </summary>
        [JsonProperty("x")]
        public required double X { get; init; }

        /// <summary>
        /// x number
        /// </summary>
        [JsonProperty("y")]
        public required double Y { get; init; }

        /// <summary>
        /// z number
        /// </summary>
        [JsonProperty("z")]
        public required double Z { get; init; }
    }
}