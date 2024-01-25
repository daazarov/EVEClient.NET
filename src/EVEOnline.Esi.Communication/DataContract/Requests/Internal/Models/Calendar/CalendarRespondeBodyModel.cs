using EVEOnline.Esi.Communication.Extensions;
using Newtonsoft.Json;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CalendarRespondeBodyModel
    {
        public CalendarRespondeBodyModel(EventResponse response)
        {
            Response = response.GetEnumMemberAttributeValue();
        }

        [JsonProperty("response")]
        public string Response { get; set; }
    }
}
