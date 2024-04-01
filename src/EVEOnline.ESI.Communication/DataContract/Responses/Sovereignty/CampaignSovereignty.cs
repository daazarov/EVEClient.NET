using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class CampaignSovereignty
    {
        /// <summary>
        /// Score for all attacking parties, only present in Defense Events.
        /// </summary>
        [JsonProperty("attackers_score")]
        public float AttackersScore {  get; set; }

        /// <summary>
        /// Unique ID for this campaign.
        /// </summary>
        [JsonProperty("campaign_id")]
        public int CampaignId { get; set; }

        /// <summary>
        /// The constellation in which the campaign will take place.
        /// </summary>
        [JsonProperty("constellation_id")]
        public int ConstellationId { get; set; }

        /// <summary>
        /// Defending alliance, only present in Defense Events
        /// </summary>
        [JsonProperty("defender_id")]
        public int? DefenderId { get; set; }

        /// <summary>
        /// Score for the defending alliance, only present in Defense Events.
        /// </summary>
        [JsonProperty("defender_score")]
        public float? DefenderScore { get; set; }

        /// <summary>
        /// Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as "Defense Events", station_freeport as "Freeport Events".
        /// </summary>
        [JsonProperty("event_type")]
        public CampaignEventType EventType { get; set; }

        /// <summary>
        /// Alliance participating and their respective scores, only present in Freeport Events.
        /// </summary>
        [JsonProperty("participants")]
        public List<Participant> Participants { get; set; }

        /// <summary>
        /// The solar system the structure is located in.
        /// </summary>
        [JsonProperty("solar_system_id")]
        public int SolarSystemId { get; set; }

        /// <summary>
        /// Time the event is scheduled to start.
        /// </summary>
        [JsonProperty("start_time")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// The structure item ID that is related to this campaign.
        /// </summary>
        [JsonProperty("structure_id")]
        public long StructureId { get; set; }

        public class Participant
        {
            /// <summary>
            /// alliance_id integer
            /// </summary>
            [JsonProperty("alliance_id")]
            public int AllianceId { get; set; }

            /// <summary>
            /// score number
            /// </summary>
            [JsonProperty("score")]
            public float Score { get; set; }
        }
    }
}
