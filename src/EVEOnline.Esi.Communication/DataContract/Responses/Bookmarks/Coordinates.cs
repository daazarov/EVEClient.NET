using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract
{
    public class Coordinates
    {
        /// <summary>
        /// x number
        /// </summary>
        [JsonProperty("x")]
        public double X { get; set; }

        /// <summary>
        /// x number
        /// </summary>
        [JsonProperty("y")]
        public double Y { get; set; }

        /// <summary>
        /// z number
        /// </summary>
        [JsonProperty("z")]
        public double Z { get; set; }
    }
}