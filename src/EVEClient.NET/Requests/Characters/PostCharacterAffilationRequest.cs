using EVEClient.NET.Models;

namespace EVEClient.NET.Requests.Characters
{
    public class PostCharacterAffilationRequest : EsiRequest
    {
        public required int[] CharacterIds { get; init; }

        public override void InitializeParameters()
        {
            Parameters.Body = CharacterIds;
        }
    }
}
