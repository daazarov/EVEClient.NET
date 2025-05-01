using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class MailingList
    {
        /// <summary>
        /// Mailing list ID
        /// </summary>
        [JsonPropertyName("mailing_list_id")]
        public required int MailingListId { get; init; }

        /// <summary>
        /// name string
        /// </summary>
        [JsonPropertyName("name")]
        public required string Name { get; init; }
    }
}
