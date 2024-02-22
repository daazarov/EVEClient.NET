using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class OpportunitiesGroupIdModel
    {
        public OpportunitiesGroupIdModel(int groupId)
        {
            GroupId = groupId;
        }

        [PathParameter("group_id")]
        public int GroupId {  get; set; }
    }
}
