using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class GetCharacterStandingsRequest : RouteModelBase<CharacterIdModel>
    {
        public GetCharacterStandingsRequest(CharacterIdModel uriModel) : base(uriModel)
        { }
    }
    internal class GetCharacterPulicInformationRequest : RouteModelBase<CharacterIdModel>
    {
        public GetCharacterPulicInformationRequest(CharacterIdModel uriModel) : base(uriModel)
        { }
    }
}
