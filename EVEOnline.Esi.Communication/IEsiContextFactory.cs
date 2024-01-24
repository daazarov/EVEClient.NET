using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using System;

namespace EVEOnline.Esi.Communication
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName);
        EsiContext CreateContext(string endpointId, Type callingMemberType, string callingMemberName, IRequestModel requestModel);
    }
}
