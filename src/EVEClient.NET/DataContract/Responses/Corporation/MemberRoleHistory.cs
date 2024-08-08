using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class MemberRoleHistory
    {
        /// <summary>
        /// changed_at string
        /// </summary>
        [JsonProperty("changed_at")]
        public DateTime ChangedAt { get; init; }

        /// <summary>
        /// The character whose roles are changed
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; init; }

        /// <summary>
        /// ID of the character who issued this change
        /// </summary>
        [JsonProperty("issuer_id")]
        public int IssuerId { get; init; }

        /// <summary>
        /// new_roles array
        /// </summary>
        [JsonProperty("new_roles")]
        public CorporationRole[] NewRoles { get; init; }

        /// <summary>
        /// old_roles array
        /// </summary>
        [JsonProperty("old_roles")]
        public CorporationRole[] OldRoles { get; init; }

        /// <summary>
        /// role_type string
        /// </summary>
        [JsonProperty("role_type")]
        public CorporationRoleType RoleType { get; init; }
    }
}
