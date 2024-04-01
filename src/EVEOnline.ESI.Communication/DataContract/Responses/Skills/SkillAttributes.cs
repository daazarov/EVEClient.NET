using System;
using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class SkillAttributes
    {
        /// <summary>
        /// Neural remapping cooldown after a character uses remap accrued over time
        /// </summary>
        [JsonProperty("accrued_remap_cooldown_date")]
        public DateTime? AccruedRemapCooldownDate { get; set; }

        /// <summary>
        /// Number of available bonus character neural remaps
        /// </summary>
        [JsonProperty("bonus_remaps")]
        public int? BonusRemaps { get; set; }

        /// <summary>
        /// charisma integer
        /// </summary>
        [JsonProperty("charisma")]
        public int Charisma { get; set; }

        /// <summary>
        /// intelligence integer
        /// </summary>
        [JsonProperty("intelligence")]
        public int Intelligence { get; set; }

        /// <summary>
        /// Datetime of last neural remap, including usage of bonus remaps
        /// </summary>
        [JsonProperty("last_remap_date")]
        public DateTime? LastRemapDate { get; set; }

        /// <summary>
        /// memory integer
        /// </summary>
        [JsonProperty("memory")]
        public int Memory { get; set; }

        /// <summary>
        /// perception integer
        /// </summary>
        [JsonProperty("perception")]
        public int Perception { get; set; }

        /// <summary>
        /// willpower integer
        /// </summary>
        [JsonProperty("willpower")]
        public int Willpower { get; set; }
    }
}
