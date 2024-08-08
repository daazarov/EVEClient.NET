using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CustomOffice
    {
        /// <summary>
        /// Only present if alliance access is allowed
        /// </summary>
        [JsonProperty("alliance_tax_rate")]
        public float? AllianceTaxRate { get; init; }

        /// <summary>
        /// standing_level and any standing related tax rate only present when this is true
        /// </summary>
        [JsonProperty("allow_access_with_standings")]
        public bool AllowAccessWithStandings { get; init; }

        /// <summary>
        /// allow_alliance_access boolean
        /// </summary>
        [JsonProperty("allow_alliance_access")]
        public bool AllowAllianceAccess { get; init; }

        /// <summary>
        /// bad_standing_tax_rate number
        /// </summary>
        [JsonProperty("bad_standing_tax_rate")]
        public float? BadStandingTaxRate { get; init; }

        /// <summary>
        /// corporation_tax_rate number
        /// </summary>
        [JsonProperty("corporation_tax_rate")]
        public float? CorporationTaxRate { get; init; }

        /// <summary>
        /// Tax rate for entities with excellent level of standing, only present if this level is allowed, same for all other standing related tax rates
        /// </summary>
        [JsonProperty("excellent_standing_tax_rate")]
        public float? ExcellentStandingTaxRate { get; init; }

        /// <summary>
        /// good_standing_tax_rate number
        /// </summary>
        [JsonProperty("good_standing_tax_rate")]
        public float? GoodStandingTaxRate { get; init; }

        /// <summary>
        /// neutral_standing_tax_rate number
        /// </summary>
        [JsonProperty("neutral_standing_tax_rate")]
        public float? NeutralStandingTaxRate { get; init; }

        /// <summary>
        /// unique ID of this customs office
        /// </summary>
        [JsonProperty("office_id")]
        public long OfficeId { get; init; }

        /// <summary>
        /// reinforce_exit_end integer
        /// </summary>
        [JsonProperty("reinforce_exit_end")]
        public int ReinforceExitEnd { get; init; }

        /// <summary>
        /// Together with reinforce_exit_end, marks a 2-hour period where this customs office could exit reinforcement mode during the day after initial attack
        /// </summary>
        [JsonProperty("reinforce_exit_start")]
        public int ReinforceExitStart { get; init; }

        /// <summary>
        /// Access is allowed only for entities with this level of standing or better
        /// </summary>
        [JsonProperty("standing_level")]
        public StandingLevel? StandingLevel { get; init; }

        /// <summary>
        /// ID of the solar system this customs office is located in
        /// </summary>
        [JsonProperty("system_id")]
        public int SystemId { get; init; }

        /// <summary>
        /// terrible_standing_tax_rate number
        /// </summary>
        [JsonProperty("terrible_standing_tax_rate")]
        public float? TerribleStandingTaxRate { get; init; }
    }
}
