using System;
using EVEClient.NET.Models;

namespace EVEClient.NET
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(Type callingMemberType, string callingMemberName);
        EsiContext CreateContext(Type callingMemberType, string callingMemberName, IRequestModel requestModel);
    }
}
