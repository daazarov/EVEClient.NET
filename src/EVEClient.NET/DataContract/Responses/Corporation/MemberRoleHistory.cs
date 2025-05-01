using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MemberRoleHistory
    {
        /// <summary>
        /// changed_at string
        /// </summary>
        [JsonPropertyName("changed_at")]
        public required DateTime ChangedAt { get; init; }

        /// <summary>
        /// The character whose roles are changed
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// ID of the character who issued this change
        /// </summary>
        [JsonPropertyName("issuer_id")]
        public required int IssuerId { get; init; }

        /// <summary>
        /// new_roles array
        /// </summary>
        [JsonPropertyName("new_roles")]
        public required CorporationRole[] NewRoles { get; init; }

        /// <summary>
        /// old_roles array
        /// </summary>
        [JsonPropertyName("old_roles")]
        public required CorporationRole[] OldRoles { get; init; }

        /// <summary>
        /// role_type string
        /// </summary>
        [JsonPropertyName("role_type")]
        public required CorporationRoleType RoleType { get; init; }
    }
}
