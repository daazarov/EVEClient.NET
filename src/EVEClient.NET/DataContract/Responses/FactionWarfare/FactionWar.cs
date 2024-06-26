﻿using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class FactionWar
    {
        /// <summary>
        /// The faction ID of the enemy faction.
        /// </summary>
        [JsonProperty("faction_id")]
        public int FactionId { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("against_id")]
        public int AgainstId { get; set; }
    }
}
