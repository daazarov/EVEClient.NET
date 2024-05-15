using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
