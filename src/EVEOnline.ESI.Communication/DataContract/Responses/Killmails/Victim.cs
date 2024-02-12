using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class Victim
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId { get; set; }

        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int? CharacterId { get; set; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; set; }

        /// <summary>
        /// How much total damage was taken by the victim
        /// </summary>
        [JsonProperty("damage_taken")]
        public int DamageTaken { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public List<KillmailItem> Items { get; set; }

        /// <summary>
        /// position
        /// </summary>
        [JsonProperty("position")]
        public Position Position { get; set; }

        /// <summary>
        /// The ship that the victim was piloting and was destroyed
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; set; }
    }
}
