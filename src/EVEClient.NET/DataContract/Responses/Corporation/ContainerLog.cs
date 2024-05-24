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
        public ContainerAction Action {  get; set; }

        /// <summary>
        /// ID of the character who performed the action.
        /// </summary>
        [JsonProperty("character_id")]
        public int CharacterId { get; set; }

        /// <summary>
        /// ID of the container
        /// </summary>
        [JsonProperty("container_id")]
        public long Container_id { get; set; }

        /// <summary>
        /// Type ID of the container
        /// </summary>
        [JsonProperty("container_type_id")]
        public int ContainerTypeId { get; set; }

        /// <summary>
        /// location_flag string
        /// </summary>
        [JsonProperty("location_flag")]
        public CorporationLocationType LocationFlag { get; set; }

        /// <summary>
        /// location_id integer
        /// </summary>
        [JsonProperty("location_id")]
        public long LocationId { get; set; }

        /// <summary>
        /// Timestamp when this log was created
        /// </summary>
        [JsonProperty("logged_at")]
        public DateTime LoggedAt { get; set; }

        /// <summary>
        /// new_config_bitmask integer
        /// </summary>
        [JsonProperty("new_config_bitmask")]
        public int? NewConfigBitmask { get; set; }

        /// <summary>
        /// old_config_bitmask integer
        /// </summary>
        [JsonProperty("old_config_bitmask")]
        public int? OldConfigBitmask { get; set; }

        /// <summary>
        /// Type of password set if action is of type SetPassword or EnterPassword
        /// </summary>
        [JsonProperty("password_type")]
        public ContainerPasswordType PasswordType { get; set; }

        /// <summary>
        /// Quantity of the item being acted upon
        /// </summary>
        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        /// <summary>
        /// Type ID of the item being acted upon
        /// </summary>
        [JsonProperty("type_id")]
        public int? TypeId { get; set; }
    }
}
