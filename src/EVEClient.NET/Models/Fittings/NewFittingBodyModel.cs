using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

using EVEClient.NET.DataContract;
using EVEClient.NET.Extensions;

namespace EVEClient.NET.Models
{
    internal class NewFittingBodyModel
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("items")]
        public List<FittingItemBodyModel> Items { get; set; }

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
                Items = fitting.Items.Select(FittingItemBodyModel.FromDataContractModel).ToList()
            };
        }
    }

    internal class FittingItemBodyModel
    {
        [JsonProperty("type_id")]
        public int TypeId { get; set; }

        [JsonProperty("flag")]
        public string Flag { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        public static FittingItemBodyModel FromDataContractModel(NewFitting.FittingItem item)
        {
            return new FittingItemBodyModel
            { 
                TypeId = item.TypeId,
                Quantity = item.Quantity,
                Flag = item.Flag.ToEsiString()
            };
        }
    }
}
