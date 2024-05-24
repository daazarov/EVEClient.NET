using System.Collections.Generic;

namespace EVEClient.NET.Models
{
    internal class CharacterIdsBodyModel : List<int>
    {
        public CharacterIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
