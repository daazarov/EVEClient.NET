using Newtonsoft.Json;

namespace EVEClient.NET.Models
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
