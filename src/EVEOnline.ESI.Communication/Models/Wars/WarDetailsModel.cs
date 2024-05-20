using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class WarDetailsModel
    {
        public WarDetailsModel(int warId)
        {
            WarId = warId;
        }

        [PathParameter("war_id")]
        public int WarId { get; private set; }
    }
}
