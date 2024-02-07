using Newtonsoft.Json;
using System.Collections.Generic;
using EVEOnline.ESI.Communication.DataContract;

namespace EVEOnline.ESI.Communication.Models
{
    internal class NewFittingBodyModel
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public List<FittingItem> Items { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("ship_type_id")]
        public int ShipTypeId { get; set; }

        public static NewFittingBodyModel FromExternalModel(NewFitting fitting)
        {
            return new NewFittingBodyModel
            {
                Description = fitting.Description,
                Name = fitting.Name,
                ShipTypeId = fitting.ShipTypeId,
                Items = fitting.Items
            };
        }
    }
}
