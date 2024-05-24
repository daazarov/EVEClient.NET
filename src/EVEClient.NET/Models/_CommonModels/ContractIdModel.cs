using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class ContractIdModel
    {
        public ContractIdModel(int contractId)
        {
            ContractId = contractId;
        }

        [PathParameter("contract_id")]
        public int ContractId { get; set; }
    }
}
