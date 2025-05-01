using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum ContainerPasswordType
    {
        [EnumMember(Value = "config")] Config,
        [EnumMember(Value = "general")] General
    }
}
