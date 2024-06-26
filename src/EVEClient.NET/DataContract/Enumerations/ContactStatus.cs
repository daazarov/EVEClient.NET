﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace EVEClient.NET.DataContract
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ContactStatus
    {
        [EnumMember(Value = "outstanding")] Outstanding,
        [EnumMember(Value = "in_progress")] InProgress,
        [EnumMember(Value = "finished_issuer")] FinishedIssuer,
        [EnumMember(Value = "finished_contractor")] FinishedContractor,
        [EnumMember(Value = "finished")] Finished,
        [EnumMember(Value = "cancelled")] Cancelled,
        [EnumMember(Value = "rejected")] Rejected,
        [EnumMember(Value = "failed")] Failed,
        [EnumMember(Value = "deleted")] Deleted,
        [EnumMember(Value = "reversed")] Reversed
    }
}
