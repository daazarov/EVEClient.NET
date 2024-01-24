using EVEOnline.Esi.Communication.DataContract;
using EVEOnline.Esi.Communication.DataContract.Requests.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class CharacterLogic : ICharacterLogic
    {
        private readonly IEsiHttpClient<ICharacterLogic> _esiClient;

        public CharacterLogic(IEsiHttpClient<ICharacterLogic> esiClient)
        { 
            _esiClient = esiClient;
        }

        public Task<EsiResponse<CharacterPublicInformation>> GetCharacterPulicInformationAsync(int characterId) =>
            _esiClient.GetRequestAsync<GetCharacterPulicInformationRequest, CharacterPublicInformation>(new GetCharacterPulicInformationRequest(new CharacterIdModel(characterId)));

        public Task<EsiResponse<IEnumerable<CharacterStanding>>> GetCharacterStandingsAsync(int characterId) =>
            _esiClient.GetRequestAsync<GetCharacterStandingsRequest, IEnumerable<CharacterStanding>>(new GetCharacterStandingsRequest(new CharacterIdModel(characterId)));
    }
}
