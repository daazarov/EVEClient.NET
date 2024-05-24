using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
