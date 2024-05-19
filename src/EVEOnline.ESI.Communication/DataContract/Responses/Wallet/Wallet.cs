using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
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
