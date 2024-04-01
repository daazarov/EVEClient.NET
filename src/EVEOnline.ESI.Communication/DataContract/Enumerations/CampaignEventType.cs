using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CampaignEventType
    {
        [EnumMember(Value = "tcu_defense")] TcuDefense,
        [EnumMember(Value = "ihub_defense")] IhubDefense,
        [EnumMember(Value = "station_defense")] StationDefense,
        [EnumMember(Value = "station_freeport")] StationFreeport
    }
}
