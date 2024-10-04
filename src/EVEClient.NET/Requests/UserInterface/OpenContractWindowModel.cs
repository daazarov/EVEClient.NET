using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
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
