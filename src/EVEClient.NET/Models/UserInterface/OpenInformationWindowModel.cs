using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class OpenInformationWindowModel
    {
        public OpenInformationWindowModel(int targetId)
        {
            TargetId = targetId;
        }

        [QueryParameter("target_id")]
        public int TargetId { get; set; }
    }
}
