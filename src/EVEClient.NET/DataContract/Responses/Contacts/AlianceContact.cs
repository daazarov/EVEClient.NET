using System.Collections.Generic;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class AlianceContact
    {
        /// <summary>
        /// contact_id integer
        /// </summary>
        [JsonProperty("contact_id")]
        public required int ContactId {  get; set; }

        /// <summary>
        /// contact_type string
        /// </summary>
        [JsonProperty("contact_type")]
        public required ContactType ContactType { get; init; }

        /// <summary>
        /// Label IDs applied to the contact
        /// </summary>
        [JsonProperty("label_ids")]
        public List<long>? LabelIds { get; init; }

        /// <summary>
        /// Standing of the contact
        /// </summary>
        [JsonProperty("standing")]
        public required float Standing { get; init; }
    }
}
