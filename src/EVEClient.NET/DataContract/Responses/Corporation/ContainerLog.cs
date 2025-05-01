using System;
using System.Text.Json.Serialization;

namespace EVEClient.NET.DataContract
{
    public class ContainerLog
    {
        /// <summary>
        /// action string
        /// </summary>
        [JsonPropertyName("action")]
        public required ContainerAction Action { get; init; }

        /// <summary>
        /// ID of the character who performed the action.
        /// </summary>
        [JsonPropertyName("character_id")]
        public required int CharacterId { get; init; }

        /// <summary>
        /// ID of the container
        /// </summary>
        [JsonPropertyName("container_id")]
        public required long Container_id { get; init; }

        /// <summary>
        /// Type ID of the container
        /// </summary>
        [JsonPropertyName("container_type_id")]
        public required int ContainerTypeId { get; init; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonPropertyName("location_flag")]
        public required CorporationLocationType LocationFlag { get; init; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonPropertyName("location_id")]
        public required long LocationId { get; init; }

        /// <summary>
        /// Timestamp when this log was created
        /// </summary>
        [JsonPropertyName("logged_at")]
        public required DateTime LoggedAt { get; init; }

        /// <summary>
        /// new_config_bitmask integer
        /// </summary>
        [JsonPropertyName("new_config_bitmask")]
        public int? NewConfigBitmask { get; init; }

        /// <summary>
        /// old_config_bitmask integer
        /// </summary>
        [JsonPropertyName("old_config_bitmask")]
        public int? OldConfigBitmask { get; init; }

        /// <summary>
        /// Type of password set if action is of type SetPassword or EnterPassword
        /// </summary>
        [JsonPropertyName("password_type")]
        public ContainerPasswordType? PasswordType { get; init; }

        /// <summary>
        /// Quantity of the item being acted upon
        /// </summary>
        [JsonPropertyName("quantity")]
        public int? Quantity { get; init; }

        /// <summary>
        /// Type ID of the item being acted upon
        /// </summary>
        [JsonPropertyName("type_id")]
        public int? TypeId { get; init; }
    }
}
