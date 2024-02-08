using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FleetRole
    {
        [EnumMember(Value = "fleet_commander")] FleetCommander,
        [EnumMember(Value = "squad_commander")] SquadCommander,
        [EnumMember(Value = "squad_member")] SquadMember,
        [EnumMember(Value = "wing_commander")] WingCommander
    }
}
