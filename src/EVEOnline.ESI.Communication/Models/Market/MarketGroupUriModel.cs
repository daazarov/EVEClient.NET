using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class MarketGroupUriModel
    {
        public MarketGroupUriModel(int marketGroupId)
        {
            MarketGroupId = marketGroupId;
        }

        [PathParameter("market_group_id")]
        public int MarketGroupId {  get; set; }
    }
}
