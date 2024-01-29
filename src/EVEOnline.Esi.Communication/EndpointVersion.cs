using System;

namespace EVEOnline.Esi.Communication
{
    [Flags]
    public enum EndpointVersion
    {
        Latest = 1,
        Dev = 2,
        Legacy = 4,
        V1 = 8,
        V2 = 16,
        V3 = 32,
        V4 = 64,
        V5 = 128,
        V6 = 256
    }
}
