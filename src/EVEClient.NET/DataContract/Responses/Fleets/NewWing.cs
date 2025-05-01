using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NewWing
    {
        /// <summary>
        /// The wing_id of the newly created wing
        /// </summary>
        [JsonPropertyName("wing_id")]
        public required long WingId { get; init; }
    }
}
