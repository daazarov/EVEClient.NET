using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContainerAction
    {
        [EnumMember(Value = "add")] Add,
        [EnumMember(Value = "assemble")] Assemble,
        [EnumMember(Value = "configure")] Configure,
        [EnumMember(Value = "enter_password")] EnterPassword,
        [EnumMember(Value = "lock")] Lock,
        [EnumMember(Value = "move")] Move,
        [EnumMember(Value = "repackage")] Repackage,
        [EnumMember(Value = "set_name")] SetName,
        [EnumMember(Value = "set_password")] SetPassword,
        [EnumMember(Value = "unlock")] Unlock
    }
}
