using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class StarbaseInfo
    {
        /// <summary>
        /// allow_alliance_members boolean
        /// </summary>
        [JsonPropertyName("allow_alliance_members")]
        public required bool AllowAllianceMembers { get; init; }

        /// <summary>
        /// allow_corporation_members boolean
        /// </summary>
        [JsonPropertyName("allow_corporation_members")]
        public required bool AllowCorporationMembers { get; init; }

        /// <summary>
        /// Who can anchor starbase (POS) and its structures
        /// </summary>
        [JsonPropertyName("anchor")]
        public required string Anchor { get; init; }

        /// <summary>
        /// attack_if_at_war boolean
        /// </summary>
        [JsonPropertyName("attack_if_at_war")]
        public required bool AttackIfAtWar { get; init; }

        /// <summary>
        /// attack_if_other_security_status_dropping boolean
        /// </summary>
        [JsonPropertyName("attack_if_other_security_status_dropping")]
        public required bool AttackIfOtherSecurityStatusDropping { get; init; }

        /// <summary>
        /// Starbase (POS) will attack if target’s security standing is lower than this value
        /// </summary>
        [JsonPropertyName("attack_security_status_threshold")]
        public float? AttackSecurityStatusThreshold { get; init; }

        /// <summary>
        /// Starbase (POS) will attack if target’s standing is lower than this value
        /// </summary>
        [JsonPropertyName("attack_standing_threshold")]
        public float? AttackStandingThreshold { get; init; }

        /// <summary>
        /// Who can take fuel blocks out of the starbase (POS)'s fuel bay
        /// </summary>
        [JsonPropertyName("fuel_bay_take")]
        public required string FuelBayTake { get; init; }

        /// <summary>
        /// Who can view the starbase (POS)'s fule bay.
        /// Characters either need to have required role or belong to the starbase (POS) owner’s corporation or alliance,
        /// as described by the enum, all other access settings follows the same scheme
        /// </summary>
        [JsonPropertyName("fuel_bay_view")]
        public required string FuelBayView { get; init; }

        /// <summary>
        /// Fuel blocks and other things that will be consumed when operating a starbase (POS)
        /// </summary>
        [JsonPropertyName("fuels")]
        public Fuel[]? Fuels { get; init; }

        /// <summary>
        /// Who can offline starbase (POS) and its structures
        /// </summary>
        [JsonPropertyName("offline")]
        public required string Offline { get; init; }

        /// <summary>
        /// Who can online starbase (POS) and its structures
        /// </summary>
        [JsonPropertyName("online")]
        public required string Online { get; init; }

        /// <summary>
        /// Who can unanchor starbase (POS) and its structures
        /// </summary>
        [JsonPropertyName("unanchor")]
        public required string Unanchor { get; init; }

        /// <summary>
        /// True if the starbase (POS) is using alliance standings, otherwise using corporation’s
        /// </summary>
        [JsonPropertyName("use_alliance_standings")]
        public required bool UseAllianceStandings { get; init; }
    }

    public class Fuel
    {
        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonPropertyName("quantity")]
        public required int Quantity { get; init; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonPropertyName("type_id")]
        public required int TypeId { get; init; }
    }
}
