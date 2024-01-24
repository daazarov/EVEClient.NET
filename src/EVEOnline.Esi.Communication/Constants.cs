using System.Collections.Generic;

namespace EVEOnline.Esi.Communication
{
    public class Esi
    {
        internal static List<string> MethodNames => new List<string>
        {
            CharacterLogic.PulicInformationMethodName,
            CharacterLogic.PulicInformationMethodName
        };

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
        
        public class CharacterLogic
        {
            public const string PulicInformationMethodName = "GetCharacterPulicInformationAsync";
            public const string CharacterStandingsMethodName = "GetCharacterStandingsAsync";

            internal class GetCharacterPulicInformationRoutes
            {
                public const EndpointType Latest = EndpointType.Latest;
                public const EndpointType V5 = EndpointType.V5;
                public const EndpointType Legacy = EndpointType.Legacy;
                public const EndpointType Dev = EndpointType.Dev;
            }

            internal class GetCharacterStandingsRoutes
            {
                public const EndpointType Latest = EndpointType.Latest;
                public const EndpointType V2 = EndpointType.V2;
                public const EndpointType Dev = EndpointType.Dev;
            }
        }
    }
}
