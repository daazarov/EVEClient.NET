using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
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
