using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class RegionOrdersUriModel
    {
        public RegionOrdersUriModel(int regionId, string orderType, int? typeId, int page)
        { 
            RegionId = regionId;
            OrderType = orderType;
            TypeId = typeId;
            Page = page;
        }

        [QueryParameter("order_type")]
        public string OrderType { get; set; }

        [PathParameter("region_id")]
        public int RegionId { get; set; }

        [QueryParameter("type_id")]
        public int? TypeId { get; set; }

        [QueryParameter("page")]
        public int Page {  get; set; }
    }
}
