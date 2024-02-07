using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class NewFittingResponse
    {
        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonProperty("fitting_id")]
        public int FittingId {  get; set; }
    }
}
