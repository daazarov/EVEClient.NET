using EVEOnline.Esi.Communication.DataContract.Requests.Internal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.DataContract.Requests.Internal
{
    internal class CharactersRequests
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

    internal class AllianceRequests
    {
        internal class AllianceIdRouteRequest : RouteModelBase<AllianceIdModel>
        {
            public AllianceIdRouteRequest(AllianceIdModel uriModel) : base(uriModel)
            { }

            public static AllianceIdRouteRequest Create(int allianceId)
            {
                return new AllianceIdRouteRequest(new AllianceIdModel(allianceId));
            }
        }
    }

    internal class AssetsRequests
    {
        internal class CharacterItemsPostRequest : RequestBase<CharacterIdModel, AssertItemBodyModel>
        {
            public CharacterItemsPostRequest(CharacterIdModel uriModel, AssertItemBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static CharacterItemsPostRequest Create(int characterId, long[] itemIds)
            {
                return new CharacterItemsPostRequest(new CharacterIdModel(characterId), new AssertItemBodyModel(itemIds));
            }
        }

        internal class PageBasedCharacterIdRouteRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            public PageBasedCharacterIdRouteRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCharacterIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedCharacterIdRouteRequest(new PageBasedCharacterIdModel(characterId, page));
            }
        }

        internal class CorporationItemsPostRequest : RequestBase<CorporationIdModel, AssertItemBodyModel>
        {
            public CorporationItemsPostRequest(CorporationIdModel uriModel, AssertItemBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static CorporationItemsPostRequest Create(int corporationId, long[] itemIds)
            {
                return new CorporationItemsPostRequest(new CorporationIdModel(corporationId), new AssertItemBodyModel(itemIds));
            }
        }

        internal class PageBasedCorporationIdRouteRequest : RouteModelBase<PageBasedCorporationIdModel>
        {
            public PageBasedCorporationIdRouteRequest(PageBasedCorporationIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCorporationIdRouteRequest Create(int corporationId, int page)
            {
                return new PageBasedCorporationIdRouteRequest(new PageBasedCorporationIdModel(corporationId, page));
            }
        }
    }
}
