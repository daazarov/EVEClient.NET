using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CorporationContractRouteModel
    {
        public CorporationContractRouteModel(int corporationId, int contractId) 
        { 
            CorporationId = corporationId;
            ContractId = contractId;
        }

        [PathParameter("contract_id")]
        public int ContractId { get; set; }

        [PathParameter("corporation_id")]
        public int CorporationId { get; set; }
    }
}
