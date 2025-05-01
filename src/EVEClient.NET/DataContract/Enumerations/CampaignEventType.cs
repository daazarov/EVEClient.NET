using EVEClient.NET.Utilities.Serialization;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum CampaignEventType
    {
        [EnumMember(Value = "tcu_defense")] TcuDefense,
        [EnumMember(Value = "ihub_defense")] IhubDefense,
        [EnumMember(Value = "station_defense")] StationDefense,
        [EnumMember(Value = "station_freeport")] StationFreeport
    }
}
