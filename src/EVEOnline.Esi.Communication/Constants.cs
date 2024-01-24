using System.Collections.Generic;

namespace EVEOnline.Esi.Communication
{
    public class Esi
    {
        internal static class EsiClientMethodNames
        {
            public const string GetRequest = "GetRequest";
            public const string GetRequestWithouRequestParameters = "GetRequestWithouRequestParameters";
            public const string GetPaginationRequest = "GetPaginationRequest";
            public const string GetPaginationRequestWithouRequestParameters = "GetPaginationRequestWithouRequestParameters";
            public const string PostRequest = "PostRequest";
            public const string PostNoContentRequest = "PostNoContentRequest";
            public const string PutNoContentRequest = "PutNoContentRequest";
            public const string DeleteNoContentRequest = "DeleteNoContentRequest";
        }
    }
}
