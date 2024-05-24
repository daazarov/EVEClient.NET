using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OrderState
    {
        Active,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "expired")] Expired
    }
}
