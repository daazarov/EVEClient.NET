using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.Configuration
{
    public class RoutePriorityConfiguration
    {
        public static RoutePriorityConfiguration Default { get; set; } = new RoutePriorityConfiguration
        {
            UseOnlyLatestRoutes = true,
            UseDevelopmentRoutes = false,
            PriorityConfigurations = new RoutePriorityCollection(0)
        };
        
        public bool UseOnlyLatestRoutes { get; set; }
        public bool UseDevelopmentRoutes { get; set; }
        public RoutePriorityCollection PriorityConfigurations { get;set;}
    }
}
