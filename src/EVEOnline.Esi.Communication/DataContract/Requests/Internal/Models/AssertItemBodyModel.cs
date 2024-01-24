using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal.Models
{
    internal class AssertItemBodyModel : List<long>
    {
        public AssertItemBodyModel(IEnumerable<long> collection) : base(collection) { }
    }
}
