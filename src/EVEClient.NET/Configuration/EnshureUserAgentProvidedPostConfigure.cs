using System;
using Microsoft.Extensions.Options;

namespace EVEClient.NET.Configuration
{
    internal class EnshureUserAgentProvidedPostConfigure : IPostConfigureOptions<EsiClientConfiguration>
    {
        public void PostConfigure(string? name, EsiClientConfiguration options)
        {
            if (string.IsNullOrEmpty(options.UserAgent))
            {
                throw new ArgumentNullException("Please specify a valid UserAgent in the EsiClientConfiguration.");
            }
        }
    }
}
