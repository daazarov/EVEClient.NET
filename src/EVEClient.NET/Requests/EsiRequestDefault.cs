using System;

namespace EVEClient.NET.Requests
{
    public class EsiRequestDefault : EsiRequest
    {
        public EsiRequestDefault(Action<Parameters> configure)
        { 
            ArgumentNullException.ThrowIfNull(configure);

            configure(Parameters);
        }
    }
}
