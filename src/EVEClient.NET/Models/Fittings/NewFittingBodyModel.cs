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
        public required string Description { get; set; }

        [JsonProperty("items")]
        public required List<FittingItemBodyModel> Items { get; set; }

        [JsonProperty("name")]
        public required string Name { get; set; }

        [JsonProperty("ship_type_id")]
        public required int ShipTypeId { get; set; }

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
        public required int TypeId { get; set; }

        [JsonProperty("flag")]
        public required string Flag { get; set; }

        [JsonProperty("quantity")]
        public required int Quantity { get; set; }

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
