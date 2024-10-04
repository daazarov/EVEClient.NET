using EVEClient.NET.Models;

namespace EVEClient.NET.Requests
{
    public class Common
    {
        public class CharacterIdRequest : EsiRequest
        {
            public required int CharacterId { get; init; }

            public override void InitializeParameters()
            {
                Parameters.Route[ESI.Parameters.Route.CharacterId] = CharacterId.ToString();
            }
        }

        public class PageBasedCharacterIdRequest : EsiRequest
        {
            public required int CharacterId { get; init; }

            public required int Page { get; init; }

            public override void InitializeParameters()
            {
                Parameters.Route[ESI.Parameters.Route.CharacterId] = CharacterId.ToString();
                Parameters.Query[ESI.Parameters.Query.Page] = Page.ToString();
            }
        }
    }
}
