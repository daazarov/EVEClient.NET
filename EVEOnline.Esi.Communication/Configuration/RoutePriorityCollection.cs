using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.Configuration
{
    public class RoutePriorityCollection : Dictionary<string, IEnumerable<RoutePriority>>
    {
        public RoutePriorityCollection() : this(0)
        { }

        public RoutePriorityCollection(int capacity) : base(capacity)
        { }
    }
}
