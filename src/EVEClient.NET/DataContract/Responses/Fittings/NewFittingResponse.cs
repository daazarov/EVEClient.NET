using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class NewFittingResponse
    {
        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonPropertyName("fitting_id")]
        public required int FittingId { get; init; }
    }
}
