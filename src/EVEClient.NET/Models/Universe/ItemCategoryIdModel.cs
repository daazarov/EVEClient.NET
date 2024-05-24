using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
