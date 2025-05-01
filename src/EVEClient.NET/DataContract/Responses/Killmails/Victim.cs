using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Victim
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
        /// How much total damage was taken by the victim
        /// </summary>
        [JsonPropertyName("damage_taken")]
        public required int DamageTaken { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonPropertyName("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonPropertyName("items")]
        public List<KillmailItem>? Items { get; init; }

        /// <summary>
        /// position
        /// </summary>
        [JsonPropertyName("position")]
        public Position? Position { get; init; }

        /// <summary>
        /// The ship that the victim was piloting and was destroyed
        /// </summary>
        [JsonPropertyName("ship_type_id")]
        public required int ShipTypeId { get; init; }
    }
}
