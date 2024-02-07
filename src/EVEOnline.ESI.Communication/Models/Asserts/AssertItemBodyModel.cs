using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Models
{
    internal class AssertItemBodyModel : List<long>
    {
        public AssertItemBodyModel(IEnumerable<long> collection) : base(collection) { }
    }
}
