using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class SkillQueueItem
    {
        /// <summary>
        /// Date on which training of the skill will complete. Omitted if the skill queue is paused.
        /// </summary>
        [JsonProperty("finish_date")]
        public DateTime? FinishDate {  get; set; }

        /// <summary>
        /// finished_level integer
        /// </summary>
        [JsonProperty("finished_level")]
        public int FinishedLevel { get; set; }

        /// <summary>
        /// level_end_sp integer
        /// </summary>
        [JsonProperty("level_end_sp")]
        public int? LevelEndSp {  get; set; }

        /// <summary>
        /// Amount of SP that was in the skill when it started training it’s current level. Used to calculate % of current level complete.
        /// </summary>
        [JsonProperty("level_start_sp")]
        public int? LevelStartSp { get; set; }

        /// <summary>
        /// queue_position integer
        /// </summary>
        [JsonProperty("queue_position")]
        public int QueuePosition { get; set; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        [JsonProperty("skill_id")]
        public int SkillId { get; set; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonProperty("start_date")]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// training_start_sp integer
        /// </summary>
        [JsonProperty("training_start_sp")]
        public int? TrainingStartSp { get; set; }
    }
}
