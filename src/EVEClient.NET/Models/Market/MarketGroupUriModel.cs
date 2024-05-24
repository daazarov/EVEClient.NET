using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
