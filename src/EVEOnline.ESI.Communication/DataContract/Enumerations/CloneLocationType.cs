using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CloneLocationType
    {
        [EnumMember(Value = "station")] Station,
        [EnumMember(Value = "structure")] Structure
    }
}
