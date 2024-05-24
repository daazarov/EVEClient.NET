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
        public List<Skill> Skills { get; set; }

        /// <summary>
        /// total_sp integer
        /// </summary>
        [JsonProperty("total_sp")]
        public long TotalSp {  get; set; }

        /// <summary>
        /// Skill points available to be assigned
        /// </summary>
        [JsonProperty("unallocated_sp")]
        public int? UnallocatedSp { get; set; }
    }

    public class Skill
    {
        /// <summary>
        /// active_skill_level integer
        /// </summary>
        [JsonProperty("active_skill_level")]
        public int ActiveSkillLevel { get; set; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        [JsonProperty("skill_id")]
        public int SkillId { get; set; }

        /// <summary>
        /// killpoints_in_skill integer
        /// </summary>
        [JsonProperty("skillpoints_in_skill")]
        public long SkillpointsInSkill { get; set; }

        /// <summary>
        /// trained_skill_level integer
        /// </summary>
        [JsonProperty("trained_skill_level")]
        public int TrainedSkillLevel { get; set; }
    }
}
