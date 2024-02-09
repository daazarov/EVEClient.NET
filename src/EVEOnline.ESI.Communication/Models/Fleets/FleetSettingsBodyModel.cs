﻿using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.Models
{
    internal class FleetSettingsBodyModel
    {
        public FleetSettingsBodyModel(bool? isFreeMove, string motd)
        { 
            IsFreeMove = isFreeMove;
            Motd = motd;
        }

        [JsonProperty("is_free_move")]
        public bool? IsFreeMove {  get; set; }

        [JsonProperty("motd")]
        public string Motd {  get; set; }

        public bool ShouldSerializeIsFreeMove() // todo -- make a test
        {
            return IsFreeMove.HasValue;
        }

        public bool ShouldSerializeMotd()
        {
            return !string.IsNullOrEmpty(Motd);
        }
    }
}
