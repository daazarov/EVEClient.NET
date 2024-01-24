using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CharacterIdsBodyModel : List<int>
    {
        public CharacterIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
