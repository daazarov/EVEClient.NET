using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class ItemGroupIdModel
    {
        public ItemGroupIdModel(int groupId)
        {
            GroupId = groupId;
        }

        [PathParameter("group_id")]
        public int GroupId { get; set; }
    }
}
