using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class ItemCategoryIdModel
    {
        public ItemCategoryIdModel(int categoryId)
        {
            CategoryId = categoryId;
        }

        [PathParameter("category_id")]
        public int CategoryId { get; set; }
    }
}
