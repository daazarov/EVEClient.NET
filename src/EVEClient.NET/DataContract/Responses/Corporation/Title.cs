using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Title
    {
        /// <summary>
        /// name string
        /// </summary>
        [JsonProperty("name")]
        public string? Name { get; init; }

        /// <summary>
        /// title_id integer
        /// </summary>
        [JsonProperty("title_id")]
        public int? TitleId { get; init; }

        /// <summary>
        /// grantable_roles array
        /// </summary>
        [JsonProperty("grantable_roles")]
        public CorporationRole[]? GrantableRoles { get; init; }

        /// <summary>
        /// grantable_roles_at_base array
        /// </summary>
        [JsonProperty("grantable_roles_at_base")]
        public CorporationRole[]? GrantableRolesAtBase { get; init; }

        /// <summary>
        /// grantable_roles_at_hq array
        /// </summary>
        [JsonProperty("grantable_roles_at_hq")]
        public CorporationRole[]? GrantableRolesAtHq { get; init; }

        /// <summary>
        /// grantable_roles_at_other array
        /// </summary>
        [JsonProperty("grantable_roles_at_other")]
        public CorporationRole[]? GrantableRolesAtOther { get; init; }

        /// <summary>
        /// roles array
        /// </summary>
        [JsonProperty("roles")]
        public CorporationRole[]? Roles { get; init; }

        /// <summary>
        /// roles_at_base array
        /// </summary>
        [JsonProperty("roles_at_base")]
        public CorporationRole[]? RolesAtBase { get; init; }

        /// <summary>
        /// roles_at_hq array
        /// </summary>
        [JsonProperty("roles_at_hq")]
        public CorporationRole[]? RolesAtHq { get; init; }

        /// <summary>
        /// roles_at_other array
        /// </summary>
        [JsonProperty("roles_at_other")]
        public CorporationRole[]? RolesAtOther { get; init; }
    }
}
