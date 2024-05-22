/*
Sketches for a separate Polly extension


using System.Collections.Generic;

namespace EVEOnline.ESI.Communication
{
    internal class RoutePriorityComparer : IComparer<RoutePriority>
    {
        public int Compare(RoutePriority? left, RoutePriority? right)
        {
            if(left == right)
                return 0;
            else if (left < right)
                return -1;
            else if (left > right)
                return 1;
            else
                return 0;
        }
    }
}
*/