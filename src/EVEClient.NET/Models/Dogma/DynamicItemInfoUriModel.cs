using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class DynamicItemInfoUriModel
    {
        public DynamicItemInfoUriModel(long itemId, int typeId) 
        { 
            ItemId = itemId;
            TypeId = typeId;
        }

        [PathParameter("item_id")]
        public long ItemId { get; set; }

        [PathParameter("type_id")]
        public int TypeId { get; set; }
    }
}
