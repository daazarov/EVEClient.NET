using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication
{
    internal interface IEndpointPriorityProvider
    {
        IEnumerable<RoutePriority> GetPriorities(string endpointId);
    }
}
