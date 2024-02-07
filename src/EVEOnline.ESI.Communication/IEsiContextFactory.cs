using EVEOnline.ESI.Communication.Models;
using System;

namespace EVEOnline.ESI.Communication
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName);
        EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName, IRequestModel requestModel);
    }
}
