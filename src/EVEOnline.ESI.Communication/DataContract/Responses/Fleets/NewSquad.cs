using Newtonsoft.Json;

namespace EVEOnline.ESI.Communication.DataContract
{
    public class NewSquad
    {
        /// <summary>
        /// The squad_id of the newly created squad
        /// </summary>
        [JsonProperty("squad_id")]
        public long SquadId { get; set; }
    }
}
