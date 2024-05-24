using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class CorporationWalletTransactionsModel
    {
        public CorporationWalletTransactionsModel(int corporationId, int divisionId, long? fromId)
        { 
            CorporationId = corporationId;
            DivisionId = divisionId;
            FromId = fromId;
        }

        [PathParameter("corporation_id")]
        public int CorporationId { get; private set; }

        [PathParameter("division_id")]
        public int DivisionId { get; private set; }

        [QueryParameter("from_id")]
        public long? FromId {  get; private set; }
    }
}
