using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CharacterIdsBodyModel : List<int>
    {
        public CharacterIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
