using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SenderType
    {
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "alliance")] Alliance,
        [EnumMember(Value = "faction")] Faction,
        [EnumMember(Value = "other")] Other
    }
}
