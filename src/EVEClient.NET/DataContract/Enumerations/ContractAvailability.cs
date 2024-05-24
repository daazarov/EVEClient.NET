using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContractAvailability
    {
        [EnumMember(Value = "public")] Public,
        [EnumMember(Value = "personal")] Personal,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "alliance")] Alliance
    }
}
