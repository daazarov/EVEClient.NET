using System;

namespace EVEClient.NET
{
    [Flags]
    public enum ExecutionOptions
    {
        None = 1,
        WithoutETag = 2
    }
}
