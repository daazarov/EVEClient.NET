using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Models
{
    internal class ContactsIdsBodyModel : List<int>
    {
        public ContactsIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
