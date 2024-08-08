using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class SkillAttributes
    {
        /// <summary>
        /// Neural remapping cooldown after a character uses remap accrued over time
        /// </summary>
        [JsonProperty("accrued_remap_cooldown_date")]
        public DateTime? AccruedRemapCooldownDate { get; init; }

        /// <summary>
        /// Number of available bonus character neural remaps
        /// </summary>
        [JsonProperty("bonus_remaps")]
        public int? BonusRemaps { get; init; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonProperty("charisma")]
        public int Charisma { get; init; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonProperty("intelligence")]
        public int Intelligence { get; init; }

        /// <summary>
        /// Datetime of last neural remap, including usage of bonus remaps
        /// </summary>
        [JsonProperty("last_remap_date")]
        public DateTime? LastRemapDate { get; init; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonProperty("memory")]
        public int Memory { get; init; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonProperty("perception")]
        public int Perception { get; init; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonProperty("willpower")]
        public int Willpower { get; init; }
    }
}
