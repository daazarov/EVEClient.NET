using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SkillDetails
    {
        /// <summary>
        /// skills array
        /// </summary>
        [JsonPropertyName("skills")]
        public required List<Skill> Skills { get; init; }

        /// <summary>
        /// total_sp integer
        /// </summary>
        [JsonPropertyName("total_sp")]
        public required long TotalSp { get; init; }

        /// <summary>
        /// Skill points available to be assigned
        /// </summary>
        [JsonPropertyName("unallocated_sp")]
        public int? UnallocatedSp { get; init; }
    }

    public class Skill
    {
        /// <summary>
        /// active_skill_level integer
        /// </summary>
        [JsonPropertyName("active_skill_level")]
        public required int ActiveSkillLevel { get; init; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        [JsonPropertyName("skill_id")]
        public required int SkillId { get; init; }

        /// <summary>
        /// killpoints_in_skill integer
        /// </summary>
        [JsonPropertyName("skillpoints_in_skill")]
        public required long SkillpointsInSkill { get; init; }

        /// <summary>
        /// trained_skill_level integer
        /// </summary>
        [JsonPropertyName("trained_skill_level")]
        public required int TrainedSkillLevel { get; init; }
    }
}
