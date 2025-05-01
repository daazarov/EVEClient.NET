using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MemberRole
    {
        /// <summary>
        /// character_id integer
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// grantable_roles array
        /// </summary>
        [JsonPropertyName("grantable_roles")]
        public CorporationRole[]? GrantableRoles { get; init; }

        /// <summary>
        /// grantable_roles_at_base array
        /// </summary>
        [JsonPropertyName("grantable_roles_at_base")]
        public CorporationRole[]? GrantableRolesAtBase { get; init; }

        /// <summary>
        /// grantable_roles_at_hq array
        /// </summary>
        [JsonPropertyName("grantable_roles_at_hq")]
        public CorporationRole[]? GrantableRolesAtHq { get; init; }

        /// <summary>
        /// grantable_roles_at_other array
        /// </summary>
        [JsonPropertyName("grantable_roles_at_other")]
        public CorporationRole[]? GrantableRolesAtOther { get; init; }

        /// <summary>
        /// roles array
        /// </summary>
        [JsonPropertyName("roles")]
        public CorporationRole[]? Roles { get; init; }

        /// <summary>
        /// roles_at_base array
        /// </summary>
        [JsonPropertyName("roles_at_base")]
        public CorporationRole[]? RolesAtBase { get; init; }

        /// <summary>
        /// roles_at_hq array
        /// </summary>
        [JsonPropertyName("roles_at_hq")]
        public CorporationRole[]? RolesAtHq { get; init; }

        /// <summary>
        /// roles_at_other array
        /// </summary>
        [JsonPropertyName("roles_at_other")]
        public CorporationRole[]? RolesAtOther { get; init; }
    }
}
