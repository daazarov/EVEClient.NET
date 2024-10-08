﻿using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterAgentsResearch
    {
        /// <summary>
        /// agent_id integer
        /// </summary>
        [JsonProperty("agent_id")]
        public required int AgentId { get; init; }

        /// <summary>
        /// points_per_day number
        /// </summary>
        [JsonProperty("points_per_day")]
        public required float PointsPerDay { get; init; }

        /// <summary>
        /// reminder_points number
        /// </summary>
        [JsonProperty("reminder_points")]
        public required float ReminderPoints { get; init; }

        /// <summary>
        /// skill_type_id integer
        /// </summary>
        [JsonProperty("skill_type_id")]
        public required int SkillTypeId { get; init; }

        /// <summary>
        /// started_at string
        /// </summary>
        [JsonProperty("started_at")]
        public required DateTime StartedAt { get; init; }
    }
}
