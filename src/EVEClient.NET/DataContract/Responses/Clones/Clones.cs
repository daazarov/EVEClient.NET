using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Clones
    {
        /// <summary>
        /// home_location object
        /// </summary>
        [JsonProperty("home_location")]
        public HomeLocation? HomeLocation { get; init; }

        /// <summary>
        /// Clone list
        /// </summary>
        [JsonProperty("jump_clones")]
        public required List<JumpClone> JumpClones { get; init; }

        /// <summary>
        /// last_clone_jump_date string
        /// </summary>
        [JsonProperty("last_clone_jump_date")]
        public DateTime? LastCloneJumpDate { get; init; }

        /// <summary>
        /// last_station_change_date string
        /// </summary>
        [JsonProperty("last_station_change_date")]
        public DateTime? LastStationChangeDate { get; init; }

        
    }
}
