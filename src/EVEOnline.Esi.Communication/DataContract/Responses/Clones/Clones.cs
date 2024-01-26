using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class Clones
    {
        /// <summary>
        /// home_location object
        /// </summary>
        [JsonProperty("home_location")]
        public HomeLocation HomeLocation { get; set; }

        /// <summary>
        /// Clone list
        /// </summary>
        [JsonProperty("jump_clones")]
        public List<JumpClone> JumpClones { get; set; } = new List<JumpClone>();

        /// <summary>
        /// last_clone_jump_date string
        /// </summary>
        [JsonProperty("last_clone_jump_date")]
        public DateTime? LastCloneJumpDate { get; set; }

        /// <summary>
        /// last_station_change_date string
        /// </summary>
        [JsonProperty("last_station_change_date")]
        public DateTime? LastStationChangeDate { get; set; }

        
    }
}
