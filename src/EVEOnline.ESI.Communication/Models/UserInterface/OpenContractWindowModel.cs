using EVEOnline.ESI.Communication.Attributes;

namespace EVEOnline.ESI.Communication.Models
{
    internal class OpenContractWindowModel
    {
        public OpenContractWindowModel(int contractId)
        { 
            ContractId = contractId;
        }

        [QueryParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
