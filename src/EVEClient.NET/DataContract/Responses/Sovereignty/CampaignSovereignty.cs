using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CampaignSovereignty
    {
        /// <summary>
        /// Score for all attacking parties, only present in Defense Events.
        /// </summary>
        [JsonProperty("attackers_score")]
        public float? AttackersScore {  get; set; }

        /// <summary>
        /// Unique ID for this campaign.
        /// </summary>
        [JsonProperty("campaign_id")]
        public required int CampaignId { get; init; }

        /// <summary>
        /// The constellation in which the campaign will take place.
        /// </summary>
        [JsonProperty("constellation_id")]
        public required int ConstellationId { get; init; }

        /// <summary>
        /// Defending alliance, only present in Defense Events
        /// </summary>
        [JsonProperty("defender_id")]
        public int? DefenderId { get; init; }

        /// <summary>
        /// Score for the defending alliance, only present in Defense Events.
        /// </summary>
        [JsonProperty("defender_score")]
        public float? DefenderScore { get; init; }

        /// <summary>
        /// Type of event this campaign is for. tcu_defense, ihub_defense and station_defense are referred to as "Defense Events", station_freeport as "Freeport Events".
        /// </summary>
        [JsonProperty("event_type")]
        public required CampaignEventType EventType { get; init; }

        /// <summary>
        /// Alliance participating and their respective scores, only present in Freeport Events.
        /// </summary>
        [JsonProperty("participants")]
        public List<Participant>? Participants { get; init; }

        /// <summary>
        /// The solar system the structure is located in.
        /// </summary>
        [JsonProperty("solar_system_id")]
        public required int SolarSystemId { get; init; }

        /// <summary>
        /// Time the event is scheduled to start.
        /// </summary>
        [JsonProperty("start_time")]
        public required DateTime StartTime { get; init; }

        /// <summary>
        /// The structure item ID that is related to this campaign.
        /// </summary>
        [JsonProperty("structure_id")]
        public required long StructureId { get; init; }

        public class Participant
        {
            /// <summary>
            /// alliance_id integer
            /// </summary>
            [JsonProperty("alliance_id")]
            public required int AllianceId { get; init; }

            /// <summary>
            /// score number
            /// </summary>
            [JsonProperty("score")]
            public required float Score { get; init; }
        }
    }
}
