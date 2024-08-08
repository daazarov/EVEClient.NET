﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Position
    {
        /// <summary>
        /// x number
        /// </summary>
        [JsonProperty("x")]
        public double X { get; init; }

        /// <summary>
        /// y number
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; init; }

        /// <summary>
        /// z number
        /// </summary>
        [JsonProperty("z")]
        public double Z { get; init; }
    }
}
