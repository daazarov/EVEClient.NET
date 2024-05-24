using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
