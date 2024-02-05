using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class DynamicItemInfoUriModel
    {
        public DynamicItemInfoUriModel(long itemId, int typeId) 
        { 
            ItemId = itemId;
            TypeId = typeId;
        }

        [RouteParameter("item_id")]
        public long ItemId { get; set; }

        [RouteParameter("type_id")]
        public int TypeId { get; set; }
    }
}
