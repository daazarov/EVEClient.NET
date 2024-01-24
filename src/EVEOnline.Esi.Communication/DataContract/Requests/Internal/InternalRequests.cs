using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CharacterIdRouteRequest : RouteModelBase<CharacterIdModel>
    {
        public CharacterIdRouteRequest(CharacterIdModel uriModel) : base(uriModel)
        { }

        public static CharacterIdRouteRequest Create(int characterId)
        {
            return new CharacterIdRouteRequest(new CharacterIdModel(characterId));
        }
    }
    internal class GetCharacterBlueprintsRequest : RouteModelBase<PageBasedCharacterIdModel>
    {
        public GetCharacterBlueprintsRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
        { }
    }
    internal class PostCharacterCspaRequest : RequestBase<CharacterIdModel, CharacterIdsBodyModel>
    {
        public PostCharacterCspaRequest(CharacterIdModel uriModel, CharacterIdsBodyModel bodyModel) : base(uriModel, bodyModel)
        { }
    }
    internal class PostCharacterAffilationRequest : BodyModelBase<CharacterIdsBodyModel>
    {
        public PostCharacterAffilationRequest(CharacterIdsBodyModel bodyModel) : base(bodyModel)
        { }
    }
}
