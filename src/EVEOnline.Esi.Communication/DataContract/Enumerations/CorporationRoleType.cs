using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CorporationRoleType
    {
        [EnumMember(Value = "grantable_roles")] Grantable_Roles,
        [EnumMember(Value = "grantable_roles_at_base")] GrantableRolesAtBase,
        [EnumMember(Value = "grantable_roles_at_hq")] GrantableRolesAtHq,
        [EnumMember(Value = "grantable_roles_at_other")] GrantableRolesAtOther,
        [EnumMember(Value = "roles")] Roles,
        [EnumMember(Value = "roles_at_base")] RolesAtBase,
        [EnumMember(Value = "roles_at_hq")] RolesAtHq,
        [EnumMember(Value = "roles_at_other")] RolesAtOther
    }
}
