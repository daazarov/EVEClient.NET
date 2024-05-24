using EVEClient.NET.Attributes;

namespace EVEClient.NET.Models
{
    internal class PageBasedContractIdModel : ContractIdModel
    {
        public PageBasedContractIdModel(int contractId, int page) : base(contractId)
        {
            Page = page;
        }

        [QueryParameter("page")]
        public int Page { get; set; }
    }
}
