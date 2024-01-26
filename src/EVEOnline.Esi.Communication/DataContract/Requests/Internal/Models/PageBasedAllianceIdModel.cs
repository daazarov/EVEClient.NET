using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class PageBasedAllianceIdModel : AllianceIdModel
    {
        public PageBasedAllianceIdModel(int allianceId, int page) : base(allianceId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
