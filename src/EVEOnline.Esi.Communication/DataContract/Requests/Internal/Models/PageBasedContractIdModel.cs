using EVEOnline.Esi.Communication.Attributes;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
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
