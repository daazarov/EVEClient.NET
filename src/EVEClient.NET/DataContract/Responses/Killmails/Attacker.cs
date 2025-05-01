using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Attacker
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonPropertyName("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonPropertyName("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// damage_done integer
        /// </summary>
        [JsonPropertyName("damage_done")]
        public required int DamageDone { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// Was the attacker the one to achieve the final blow
        /// </summary>
        [JsonPropertyName("final_blow")]
        public required bool FinalBlow { get; init; }

        /// <summary>
        /// Security status for the attacker
        /// </summary>
        [JsonPropertyName("security_status")]
        public required float SecurityStatus { get; init; }

        /// <summary>
        /// What ship was the attacker flying
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public int? ShipTypeId { get; init; }

        /// <summary>
        /// What weapon was used by the attacker for the kill
        /// </summary>
        [JsonPropertyName("weapon_type_id")]
        public int? WeaponTypeId { get; init; }
    }
}
