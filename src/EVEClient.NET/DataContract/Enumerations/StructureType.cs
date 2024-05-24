using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StructureType
    {
        [EnumMember(Value = "market")] Market,
        [EnumMember(Value = "manufacturing_basic")] ManufacturingBasic
    }
}
