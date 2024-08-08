using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SkillDetails
    {
        /// <summary>
        /// skills array
        /// </summary>
        [JsonProperty("skills")]
        public required List<Skill> Skills { get; init; }

        /// <summary>
        /// total_sp integer
        /// </summary>
        [JsonProperty("total_sp")]
        public required long TotalSp {  get; set; }

        /// <summary>
        /// Skill points available to be assigned
        /// </summary>
        [JsonProperty("unallocated_sp")]
        public int? UnallocatedSp { get; init; }
    }

    public class Skill
    {
        /// <summary>
        /// active_skill_level integer
        /// </summary>
        [JsonProperty("active_skill_level")]
        public required int ActiveSkillLevel { get; init; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        [JsonProperty("skill_id")]
        public required int SkillId { get; init; }

        /// <summary>
        /// killpoints_in_skill integer
        /// </summary>
        [JsonProperty("skillpoints_in_skill")]
        public required long SkillpointsInSkill { get; init; }

        /// <summary>
        /// trained_skill_level integer
        /// </summary>
        [JsonProperty("trained_skill_level")]
        public required int TrainedSkillLevel { get; init; }
    }
}
