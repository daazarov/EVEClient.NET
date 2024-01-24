using System;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class CharacterAgentsResearch
    {
        /// <summary>
        /// agent_id integer
        /// </summary>
        [JsonProperty("agent_id")]
        public int AgentId { get; set; }

        /// <summary>
        /// points_per_day number
        /// </summary>
        [JsonProperty("points_per_day")]
        public float PointsPerDay { get; set; }

        /// <summary>
        /// reminder_points number
        /// </summary>
        [JsonProperty("reminder_points")]
        public float ReminderPoints { get; set; }

        /// <summary>
        /// skill_type_id integer
        /// </summary>
        [JsonProperty("skill_type_id")]
        public int SkillTypeId { get; set; }

        /// <summary>
        /// started_at string
        /// </summary>
        [JsonProperty("started_at")]
        public DateTime StartedAt { get; set; }
    }
}
