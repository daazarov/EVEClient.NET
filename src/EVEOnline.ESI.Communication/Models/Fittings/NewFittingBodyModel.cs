using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;
using EVEOnline.ESI.Communication.DataContract;
using EVEOnline.ESI.Communication.Extensions;

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

        public static NewFittingBodyModel FromDataContractModel(NewFitting fitting)
        {
            return new NewFittingBodyModel
            {
                Description = fitting.Description,
                Name = fitting.Name,
                ShipTypeId = fitting.ShipTypeId,
                Items = fitting.Items.Select(x => FittingItem.FromDataContractModel(x)).ToList()
            };
        }
    }

    internal class FittingItem
    {
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        public static FittingItem FromDataContractModel(DataContract.FittingItem item)
        {
            return new FittingItem
            { 
                TypeId = item.TypeId,
                Quantity = item.Quantity,
                Flag = item.Flag.ToEsiString()
            };
        }
    }
}
