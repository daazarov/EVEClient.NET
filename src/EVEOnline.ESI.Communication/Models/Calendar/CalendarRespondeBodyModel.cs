using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CalendarRespondeBodyModel
    {
        public CalendarRespondeBodyModel(string response)
        {
            Response = response;
        }

        [JsonProperty("response")]
        public string Response { get; set; }
    }
}
