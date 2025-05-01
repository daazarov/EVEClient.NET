using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterAgentsResearch
    {
        /// <summary>
        /// agent_id integer
        /// </summary>
        [JsonPropertyName("agent_id")]
        public required int AgentId { get; init; }

        /// <summary>
        /// points_per_day number
        /// </summary>
        [JsonPropertyName("points_per_day")]
        public required float PointsPerDay { get; init; }

        /// <summary>
        /// reminder_points number
        /// </summary>
        [JsonPropertyName("reminder_points")]
        public required float ReminderPoints { get; init; }

        /// <summary>
        /// skill_type_id integer
        /// </summary>
        [JsonPropertyName("skill_type_id")]
        public required int SkillTypeId { get; init; }

        /// <summary>
        /// started_at string
        /// </summary>
        [JsonPropertyName("started_at")]
        public required DateTime StartedAt { get; init; }
    }
}
