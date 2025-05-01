using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class SkillAttributes
    {
        /// <summary>
        /// Neural remapping cooldown after a character uses remap accrued over time
        /// </summary>
        [JsonPropertyName("accrued_remap_cooldown_date")]
        public DateTime? AccruedRemapCooldownDate { get; init; }

        /// <summary>
        /// Number of available bonus character neural remaps
        /// </summary>
        [JsonPropertyName("bonus_remaps")]
        public int? BonusRemaps { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonPropertyName("charisma")]
        public required int Charisma { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonPropertyName("intelligence")]
        public required int Intelligence { get; init; }

        /// <summary>
        /// Datetime of last neural remap, including usage of bonus remaps
        /// </summary>
        [JsonPropertyName("last_remap_date")]
        public DateTime? LastRemapDate { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonPropertyName("memory")]
        public required int Memory { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonPropertyName("perception")]
        public required int Perception { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonPropertyName("willpower")]
        public required int Willpower { get; init; }
    }
}
