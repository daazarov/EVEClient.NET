using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Victim
    {
        /// <summary>
        /// alliance_id integer
        /// </summary>
        [JsonProperty("alliance_id")]
        public int? AllianceId { get; init; }

        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonProperty("character_id")]
        public int? CharacterId { get; init; }

        /// <summary>
        /// corporation_id integer
        /// </summary>
        [JsonProperty("corporation_id")]
        public int? CorporationId { get; init; }

        /// <summary>
        /// How much total damage was taken by the victim
        /// </summary>
        [JsonProperty("damage_taken")]
        public required int DamageTaken { get; init; }

        /// <summary>
        /// faction_id integer
        /// </summary>
        [JsonProperty("faction_id")]
        public int? FactionId { get; init; }

        /// <summary>
        /// items array
        /// </summary>
        [JsonProperty("items")]
        public List<KillmailItem>? Items { get; init; }

        /// <summary>
        /// position
        /// </summary>
        [JsonProperty("position")]
        public Position? Position { get; init; }

        /// <summary>
        /// The ship that the victim was piloting and was destroyed
        /// </summary>
        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; init; }
    }
}
