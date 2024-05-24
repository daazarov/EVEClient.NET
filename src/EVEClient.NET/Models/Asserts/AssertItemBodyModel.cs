using System.Collections.Generic;

namespace EVEClient.NET.Models
{
    internal class AssertItemBodyModel : List<long>
    {
        public AssertItemBodyModel(IEnumerable<long> collection) : base(collection) { }
    }
}
