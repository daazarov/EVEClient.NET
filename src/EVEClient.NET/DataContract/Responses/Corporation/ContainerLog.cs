using System;
using Newtonsoft.Json;

namespace EVEClient.NET.DataContract
{
    public class ContainerLog
    {
        /// <summary>
        /// action string
        /// </summary>
        [JsonProperty("action")]
        public required ContainerAction Action {  get; set; }

        /// <summary>
        /// ID of the character who performed the action.
        /// </summary>
        [JsonProperty("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// ID of the container
        /// </summary>
        [JsonProperty("container_id")]
        public required long Container_id { get; init; }

        /// <summary>
        /// Type ID of the container
        /// </summary>
        [JsonProperty("container_type_id")]
        public required int ContainerTypeId { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonProperty("location_flag")]
        public required CorporationLocationType LocationFlag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// Timestamp when this log was created
        /// </summary>
        [JsonProperty("logged_at")]
        public required DateTime LoggedAt { get; init; }

        /// <summary>
        /// new_config_bitmask integer
        /// </summary>
        [JsonProperty("new_config_bitmask")]
        public int? NewConfigBitmask { get; init; }

        /// <summary>
        /// old_config_bitmask integer
        /// </summary>
        [JsonProperty("old_config_bitmask")]
        public int? OldConfigBitmask { get; init; }

        /// <summary>
        /// Type of password set if action is of type SetPassword or EnterPassword
        /// </summary>
        [JsonProperty("password_type")]
        public ContainerPasswordType? PasswordType { get; init; }

        /// <summary>
        /// Quantity of the item being acted upon
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; init; }

        /// <summary>
        /// Type ID of the item being acted upon
        /// </summary>
        [JsonProperty("type_id")]
        public int? TypeId { get; init; }
    }
}
