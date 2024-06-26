﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum StandingType
    {
        [EnumMember(Value = "agent")] Agent,
        [EnumMember(Value = "npc_corp")] NpcCorporation,
        [EnumMember(Value = "faction")] Faction
    }
}
