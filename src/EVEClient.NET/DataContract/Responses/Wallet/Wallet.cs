using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class Wallet
    {
        /// <summary>
        /// balance number
        /// </summary>
        [JsonPropertyName("balance")]
        public required double Balance { get; init; }

        /// <summary>
        /// division integer
        /// </summary>
        [JsonPropertyName("division")]
        public required int Division { get; init; }
    }
}
