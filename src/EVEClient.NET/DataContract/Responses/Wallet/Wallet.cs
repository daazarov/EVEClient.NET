using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Wallet
    {
        /// <summary>
        /// balance number
        /// </summary>
        [JsonProperty("balance")]
        public required double Balance { get; init; }

        /// <summary>
        /// division integer
        /// </summary>
        [JsonProperty("division")]
        public required int Division { get; init; }
    }
}
