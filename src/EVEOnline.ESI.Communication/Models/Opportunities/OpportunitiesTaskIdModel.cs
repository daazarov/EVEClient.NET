using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class OpportunitiesTaskIdModel
    {
        public OpportunitiesTaskIdModel(int taskId)
        {
            TaskId = taskId;
        }

        [PathParameter("task_id")]
        public int TaskId {  get; set; }
    }
}
