﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEOnline.ESI.Communication.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OwnerType
    {
        [EnumMember(Value = "eve_server")] EVEServer,
        [EnumMember(Value = "corporation")] Corporation,
        [EnumMember(Value = "faction")] Faction,
        [EnumMember(Value = "character")] Character,
        [EnumMember(Value = "alliance")] Alliance
    }
}