using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class CharacterRoles
    {
        /// <summary>
        /// roles array
        /// </summary>
        [JsonProperty("roles")]
        public string[]? MainRoles { get; init; }

        /// <summary>
        /// roles_at_base array
        /// </summary>
        [JsonProperty("roles_at_base")]
        public string[]? RolesAtBase { get; init; }

        /// <summary>
        /// roles_at_hq array
        /// </summary>
        [JsonProperty("roles_at_hq")]
        public string[]? RolesAtHq { get; init; }

        /// <summary>
        /// roles_at_other array
        /// </summary>
        [JsonProperty("roles_at_other")]
        public string[]? RolesAtOther { get; init; }
    }
}
