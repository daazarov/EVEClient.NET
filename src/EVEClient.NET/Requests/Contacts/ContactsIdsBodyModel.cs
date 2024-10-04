using System.Collections.Generic;

namespace EVEClient.NET.Models
{
    internal class ContactsIdsBodyModel : List<int>
    {
        public ContactsIdsBodyModel(IEnumerable<int> collection) : base(collection) { }
    }
}
