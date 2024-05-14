using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StructureType
    {
        [EnumMember(Value = "market")] Market,
        [EnumMember(Value = "manufacturing_basic")] ManufacturingBasic
    }
}
