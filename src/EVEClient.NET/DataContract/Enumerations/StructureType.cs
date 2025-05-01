using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum StructureType
    {
        [EnumMember(Value = "market")] Market,
        [EnumMember(Value = "manufacturing_basic")] ManufacturingBasic
    }
}
