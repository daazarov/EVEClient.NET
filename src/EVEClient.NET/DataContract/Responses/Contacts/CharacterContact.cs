using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class CharacterContact
    {
        /// <summary>
        /// contact_id integer
        /// </summary>
        [JsonPropertyName("contact_id")]
        public required int ContactId { get; init; }

        /// <summary>
        /// contact_type string
        /// </summary>
        [JsonPropertyName("contact_type")]
        public required ContactType ContactType { get; init; }

        /// <summary>
        /// Whether this contact is in the blocked list.
        /// Note a missing value denotes unknown, not true or false
        /// </summary>
        [JsonPropertyName("is_blocked")]
        public bool? IsBlocked { get; init; }

        /// <summary>
        /// Whether this contact is being watched
        /// </summary>
        [JsonPropertyName("is_watched")]
        public bool? IsWatched { get; init; }

        /// <summary>
        /// Label IDs applied to the contact
        /// </summary>
        [JsonPropertyName("label_ids")]
        public List<long>? LabelIds { get; init; }

        /// <summary>
        /// Standing of the contact
        /// </summary>
        [JsonPropertyName("standing")]
        public required float Standing { get; init; }
    }
}
