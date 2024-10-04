using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
