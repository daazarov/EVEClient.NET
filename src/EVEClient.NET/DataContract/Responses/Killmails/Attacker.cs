using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Attacker
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId {  get; set; }

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
        /// damage_done integer
        /// </summary>
        [JsonProperty("damage_done")]
        public int DamageDone { get; set; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; set; }

        /// <summary>
        /// Was the attacker the one to achieve the final blow
        /// </summary>
        [JsonProperty("final_blow")]
        public bool FinalBlow { get; set; }

        /// <summary>
        /// Security status for the attacker
        /// </summary>
        [JsonProperty("security_status")]
        public float SecurityStatus { get; set; }

        /// <summary>
        /// What ship was the attacker flying
        /// </summary>
        [JsonProperty("ship_type_id")]
        public int? ShipTypeId { get; set; }

        /// <summary>
        /// What weapon was used by the attacker for the kill
        /// </summary>
        [JsonProperty("weapon_type_id")]
        public int? WeaponTypeId { get; set; }
    }
}
