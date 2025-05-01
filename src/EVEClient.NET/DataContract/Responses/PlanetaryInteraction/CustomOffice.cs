using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CustomOffice
    {
        /// <summary>
        /// Only present if alliance access is allowed
        /// </summary>
        [JsonPropertyName("alliance_tax_rate")]
        public float? AllianceTaxRate { get; init; }

        /// <summary>
        /// standing_level and any standing related tax rate only present when this is true
        /// </summary>
        [JsonPropertyName("allow_access_with_standings")]
        public required bool AllowAccessWithStandings { get; init; }

        /// <summary>
        /// allow_alliance_access boolean
        /// </summary>
        [JsonPropertyName("allow_alliance_access")]
        public required bool AllowAllianceAccess { get; init; }

        /// <summary>
        /// bad_standing_tax_rate number
        /// </summary>
        [JsonPropertyName("bad_standing_tax_rate")]
        public float? BadStandingTaxRate { get; init; }

        /// <summary>
        /// corporation_tax_rate number
        /// </summary>
        [JsonPropertyName("corporation_tax_rate")]
        public float? CorporationTaxRate { get; init; }

        /// <summary>
        /// Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates
        /// </summary>
        [JsonPropertyName("excellent_standing_tax_rate")]
        public float? ExcellentStandingTaxRate { get; init; }

        /// <summary>
        /// good_standing_tax_rate number
        /// </summary>
        [JsonPropertyName("good_standing_tax_rate")]
        public float? GoodStandingTaxRate { get; init; }

        /// <summary>
        /// neutral_standing_tax_rate number
        /// </summary>
        [JsonPropertyName("neutral_standing_tax_rate")]
        public float? NeutralStandingTaxRate { get; init; }

        /// <summary>
        /// unique ID of this customs office
        /// </summary>
        [JsonPropertyName("office_id")]
        public required long OfficeId { get; init; }

        /// <summary>
        /// reinforce_exit_end integer
        /// </summary>
        [JsonPropertyName("reinforce_exit_end")]
        public required int ReinforceExitEnd { get; init; }

        /// <summary>
        /// Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack
        /// </summary>
        [JsonPropertyName("reinforce_exit_start")]
        public required int ReinforceExitStart { get; init; }

        /// <summary>
        /// Access is allowed only for entities with this level of standing or better
        /// </summary>
        [JsonPropertyName("standing_level")]
        public StandingLevel? StandingLevel { get; init; }

        /// <summary>
        /// ID of the solar system this customs office is located in
        /// </summary>
        [JsonPropertyName("system_id")]
        public required int SystemId { get; init; }

        /// <summary>
        /// terrible_standing_tax_rate number
        /// </summary>
        [JsonPropertyName("terrible_standing_tax_rate")]
        public float? TerribleStandingTaxRate { get; init; }
    }
}
