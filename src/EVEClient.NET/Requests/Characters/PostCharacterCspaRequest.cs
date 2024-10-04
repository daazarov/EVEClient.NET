using EVEClient.NET.Models;

namespace EVEClient.NET.Requests.Characters
{
    public class PostCharacterCspaRequest : EsiRequest
    {
        public required int CharacterId { get; init; }
        public required int[] CharacterIds { get; init; }

        public override void InitializeParameters()
        {
            Parameters.Route[ESI.Parameters.Route.CharacterId] = CharacterId.ToString();
            Parameters.Body = CharacterIds;
        }
    }
}
