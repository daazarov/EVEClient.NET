using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class NewFittingResponse
    {
        /// <summary>
        /// fitting_id integer
        /// </summary>
        [JsonProperty("fitting_id")]
        public int FittingId { get; init; }
    }
}
