using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SkillQueueItem
    {
        /// <summary>
        /// Date on which training of the skill will complete. Omitted if the skill queue is paused.
        /// </summary>
        [JsonPropertyName("finish_date")]
        public DateTime? FinishDate { get; init; }

        /// <summary>
        /// finished_level integer
        /// </summary>
        [JsonPropertyName("finished_level")]
        public required int FinishedLevel { get; init; }

        /// <summary>
        /// level_end_sp integer
        /// </summary>
        [JsonPropertyName("level_end_sp")]
        public int? LevelEndSp { get; init; }

        /// <summary>
        /// Amount of SP that was in the skill when it started training it’s current level. Used to calculate % of current level complete.
        /// </summary>
        [JsonPropertyName("level_start_sp")]
        public int? LevelStartSp { get; init; }

        /// <summary>
        /// queue_position integer
        /// </summary>
        [JsonPropertyName("queue_position")]
        public required int QueuePosition { get; init; }

        /// <summary>
        /// skill_id integer
        /// </summary>
        [JsonPropertyName("skill_id")]
        public required int SkillId { get; init; }

        /// <summary>
        /// start_date string
        /// </summary>
        [JsonPropertyName("start_date")]
        public DateTime? StartDate { get; init; }

        /// <summary>
        /// training_start_sp integer
        /// </summary>
        [JsonPropertyName("training_start_sp")]
        public int? TrainingStartSp { get; init; }
    }
}
