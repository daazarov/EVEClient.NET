using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CorporationWalletJournalModel
    {
        public CorporationWalletJournalModel(int corporationId, int divisionId, int page)
        { 
            CorporationId = corporationId;
            DivisionId = divisionId;
            Page = page;
        }

        [PathParameter("corporation_id")]
        public int CorporationId { get; private set; }

        [PathParameter("division_id")]
        public int DivisionId { get; private set; }

        [QueryParameter("page")]
        public int Page {  get; private set; }
    }
}
