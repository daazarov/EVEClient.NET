using System.Text.Json.Serialization;
using System.Runtime.Serialization;
using EVEClient.NET.Utilities.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(JsonStringEnumMemberConverter))]
    public enum FleetRole
    {
        [EnumMember(Value = "fleet_commander")] FleetCommander,
        [EnumMember(Value = "squad_commander")] SquadCommander,
        [EnumMember(Value = "squad_member")] SquadMember,
        [EnumMember(Value = "wing_commander")] WingCommander
    }
}
