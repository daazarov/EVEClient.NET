using System;
using EVEOnline.ESI.Communication.Models;

namespace EVEOnline.ESI.Communication
{
    internal interface IEsiContextFactory
    {
        EsiContext CreateContext(Type callingMemberType, string callingMemberName);
        EsiContext CreateContext(Type callingMemberType, string callingMemberName, IRequestModel requestModel);
    }
}
