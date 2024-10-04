using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class OpenMarketDetailsModel
    {
        public OpenMarketDetailsModel(int typeId)
        {
            TypeId = typeId;
        }

        [QueryParameter("type_id")]
        public int TypeId { get; set; }
    }
}
