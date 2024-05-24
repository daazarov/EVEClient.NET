using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class Wallet
    {
        /// <summary>
        /// balance number
        /// </summary>
        [JsonProperty("balance")]
        public double Balance {  get; set; }

        /// <summary>
        /// division integer
        /// </summary>
        [JsonProperty("division")]
        public int Division {  get; set; }
    }
}
