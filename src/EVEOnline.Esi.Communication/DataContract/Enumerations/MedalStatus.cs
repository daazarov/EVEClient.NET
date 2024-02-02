using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.Esi.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MedalStatus
    {
        [EnumMember(Value = "private")] Private,
        [EnumMember(Value = "public")] Public
    }
}
