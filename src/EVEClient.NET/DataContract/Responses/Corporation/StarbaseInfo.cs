using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class StarbaseInfo
    {
        /// <summary>
        /// allow_alliance_members boolean
        /// </summary>
        [JsonProperty("allow_alliance_members")]
        public bool AllowAllianceMembers {  get; set; }

        /// <summary>
        /// allow_corporation_members boolean
        /// </summary>
        [JsonProperty("allow_corporation_members")]
        public bool AllowCorporationMembers { get; set; }

        /// <summary>
        /// Who can anchor starbase (POS) and its structures
        /// </summary>
        [JsonProperty("anchor")]
        public string Anchor {  get; set; }

        /// <summary>
        /// attack_if_at_war boolean
        /// </summary>
        [JsonProperty("attack_if_at_war")]
        public bool AttackIfAtWar {  get; set; }

        /// <summary>
        /// attack_if_other_security_status_dropping boolean
        /// </summary>
        [JsonProperty("attack_if_other_security_status_dropping")]
        public bool AttackIfOtherSecurityStatusDropping { get; set; }

        /// <summary>
        /// Starbase (POS) will attack if target’s security standing is lower than this value
        /// </summary>
        [JsonProperty("attack_security_status_threshold")]
        public float? AttackSecurityStatusThreshold { get; set; }

        /// <summary>
        /// Starbase (POS) will attack if target’s standing is lower than this value
        /// </summary>
        [JsonProperty("attack_standing_threshold")]
        public float? AttackStandingThreshold { get; set; }

        /// <summary>
        /// Who can take fuel blocks out of the starbase (POS)'s fuel bay
        /// </summary>
        [JsonProperty("fuel_bay_take")]
        public string FuelBayTake { get; set; }

        /// <summary>
        /// Who can view the starbase (POS)'s fule bay.
        /// Characters either need to have required role or belong to the starbase (POS) owner’s corporation or alliance,
        /// as described by the enum, all other access settings follows the same scheme
        /// </summary>
        [JsonProperty("fuel_bay_view")]
        public string FuelBayView { get; set; }

        /// <summary>
        /// Fuel blocks and other things that will be consumed when operating a starbase (POS)
        /// </summary>
        [JsonProperty("fuels")]
        public Fuel[] Fuels { get; set; }

        /// <summary>
        /// Who can offline starbase (POS) and its structures
        /// </summary>
        [JsonProperty("offline")]
        public string Offline {  get; set; }

        /// <summary>
        /// Who can online starbase (POS) and its structures
        /// </summary>
        [JsonProperty("online")]
        public string Online { get; set; }

        /// <summary>
        /// Who can unanchor starbase (POS) and its structures
        /// </summary>
        [JsonProperty("unanchor")]
        public string Unanchor { get; set; }

        /// <summary>
        /// True if the starbase (POS) is using alliance standings, otherwise using corporation’s
        /// </summary>
        [JsonProperty("use_alliance_standings")]
        public bool UseAllianceStandings { get; set; }
    }

    public class Fuel
    {
        /// <summary>
        /// quantity integer
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// type_id integer
        /// </summary>
        [JsonProperty("type_id")]
        public int TypeId { get; set; }
    }
}
