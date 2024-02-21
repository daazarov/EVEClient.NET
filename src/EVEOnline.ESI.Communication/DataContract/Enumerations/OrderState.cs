using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderState
    {
        Active,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "expired")] Expired
    }
}
