using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class KillsModel
    {
        public KillsModel(int warId, int page)
        {
            WarId = warId;
            Page = page;
        }

        [PathParameter("war_id")]
        public int WarId { get; private set; }

        [QueryParameter("page")]
        public int Page {  get; private set; }
    }
}
