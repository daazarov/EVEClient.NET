using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class ContactsIdsBodyModel : List<int>
    {
        public ContactsIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
