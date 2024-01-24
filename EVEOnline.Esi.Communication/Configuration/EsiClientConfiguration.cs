using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.Configuration
{
    public class EsiClientConfiguration
    {
        internal const string DefaultEsiConfigurationSectionName = "EsiClientConfiguration";

        public string BaseUrl { get; set; }
        public string Server { get; set; }
        public string UserAgent { get; set; }
        
        /// <summary>
        /// 
        /// </summary>
        public bool EnableETag { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public RoutePriorityConfiguration RoutePriority { get; set; } = RoutePriorityConfiguration.Default;
    }
}
