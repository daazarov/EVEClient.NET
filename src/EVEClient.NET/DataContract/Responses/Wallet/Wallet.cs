using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Wallet
    {
        /// <summary>
        /// balance number
        /// </summary>
        [JsonProperty("balance")]
        public required double Balance {  get; set; }

        /// <summary>
        /// division integer
        /// </summary>
        [JsonProperty("division")]
        public required int Division {  get; set; }
    }
}
