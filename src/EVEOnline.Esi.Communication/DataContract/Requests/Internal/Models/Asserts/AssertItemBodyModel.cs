using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class AssertItemBodyModel : List<long>
    {
        public AssertItemBodyModel(IEnumerable<long> collection) : base(collection) { }
    }
}
