using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShareholderType
    {
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "corporation")] Corporation
    }
}
