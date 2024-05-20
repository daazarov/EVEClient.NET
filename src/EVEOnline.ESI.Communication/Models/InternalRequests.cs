using EVEOnline.ESI.Communication.DataContract;
using static EVEOnline.ESI.Communication.Models.CalendarRequests;
using static EVEOnline.ESI.Communication.Models.SearchRequests;

namespace EVEOnline.ESI.Communication.Models
{
    internal class CommonRequests
    {
        internal class PageBasedRouteRequest : RouteModelBase<PageBasedModel>
        {
            private PageBasedRouteRequest(PageBasedModel uriModel) : base(uriModel)
            { }

            public static PageBasedRouteRequest Create(int page)
            {
                return new PageBasedRouteRequest(new PageBasedModel(page));
            }
        }
        
        internal class CharacterIdRouteRequest : RouteModelBase<CharacterIdModel>
        {
            private CharacterIdRouteRequest(CharacterIdModel uriModel) : base(uriModel)
            { }

            public static CharacterIdRouteRequest Create(int characterId)
            {
                return new CharacterIdRouteRequest(new CharacterIdModel(characterId));
            }
        }

        internal class AllianceIdRouteRequest : RouteModelBase<AllianceIdModel>
        {
            private AllianceIdRouteRequest(AllianceIdModel uriModel) : base(uriModel)
            { }

            public static AllianceIdRouteRequest Create(int allianceId)
            {
                return new AllianceIdRouteRequest(new AllianceIdModel(allianceId));
            }
        }

        internal class CorporationIdRouteRequest : RouteModelBase<CorporationIdModel>
        {
            private CorporationIdRouteRequest(CorporationIdModel uriModel) : base(uriModel)
            { }

            public static CorporationIdRouteRequest Create(int corporationId)
            {
                return new CorporationIdRouteRequest(new CorporationIdModel(corporationId));
            }
        }

        internal class PageBasedCharacterIdRouteRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            private PageBasedCharacterIdRouteRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCharacterIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedCharacterIdRouteRequest(new PageBasedCharacterIdModel(characterId, page));
            }
        }

        internal class PageBasedAllianceIdRouteRequest : RouteModelBase<PageBasedAllianceIdModel>
        {
            private PageBasedAllianceIdRouteRequest(PageBasedAllianceIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedAllianceIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedAllianceIdRouteRequest(new PageBasedAllianceIdModel(characterId, page));
            }
        }

        internal class PageBasedCorporationIdRouteRequest : RouteModelBase<PageBasedCorporationIdModel>
        {
            private PageBasedCorporationIdRouteRequest(PageBasedCorporationIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCorporationIdRouteRequest Create(int corporationId, int page)
            {
                return new PageBasedCorporationIdRouteRequest(new PageBasedCorporationIdModel(corporationId, page));
            }
        }
    }
    
    internal class CharactersRequests
    {
        internal class GetCharacterBlueprintsRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            private GetCharacterBlueprintsRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static GetCharacterBlueprintsRequest Create(int characterId, int page)
            {
                return new GetCharacterBlueprintsRequest(new PageBasedCharacterIdModel(characterId, page));
            }
        }

        internal class PostCharacterCspaRequest : RequestBase<CharacterIdModel, CharacterIdsBodyModel>
        {
            private PostCharacterCspaRequest(CharacterIdModel uriModel, CharacterIdsBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static PostCharacterCspaRequest Create(int characterId, int[] characterIds)
            {
                return new PostCharacterCspaRequest(new CharacterIdModel(characterId), new CharacterIdsBodyModel(characterIds));
            }
        }

        internal class PostCharacterAffilationRequest : BodyModelBase<CharacterIdsBodyModel>
        {
            private PostCharacterAffilationRequest(CharacterIdsBodyModel bodyModel) : base(bodyModel)
            { }

            public static PostCharacterAffilationRequest Create(int[] characterIds)
            {
                return new PostCharacterAffilationRequest(new CharacterIdsBodyModel(characterIds));
            }
        }
    }

    internal class AssetsRequests
    {
        internal class CharacterItemsPostRequest : RequestBase<CharacterIdModel, AssertItemBodyModel>
        {
            private CharacterItemsPostRequest(CharacterIdModel uriModel, AssertItemBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static CharacterItemsPostRequest Create(int characterId, long[] itemIds)
            {
                return new CharacterItemsPostRequest(new CharacterIdModel(characterId), new AssertItemBodyModel(itemIds));
            }
        }

        internal class CorporationItemsPostRequest : RequestBase<CorporationIdModel, AssertItemBodyModel>
        {
            private CorporationItemsPostRequest(CorporationIdModel uriModel, AssertItemBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static CorporationItemsPostRequest Create(int corporationId, long[] itemIds)
            {
                return new CorporationItemsPostRequest(new CorporationIdModel(corporationId), new AssertItemBodyModel(itemIds));
            }
        }
    }

    internal class CalendarRequests
    {
        internal class CalendarEventRequest : RouteModelBase<CharacterIdEventIdRouteModel>
        {
            private CalendarEventRequest(CharacterIdEventIdRouteModel uriModel) : base(uriModel)
            { }

            public static CalendarEventRequest Create(int characterId, int eventId)
            {
                return new CalendarEventRequest(new CharacterIdEventIdRouteModel(characterId, eventId));
            }
        }
        internal class CalendarEventAttendeesRequest : RouteModelBase<CharacterIdEventIdRouteModel>
        {
            private CalendarEventAttendeesRequest(CharacterIdEventIdRouteModel uriModel) : base(uriModel)
            { }

            public static CalendarEventAttendeesRequest Create(int characterId, int eventId)
            {
                return new CalendarEventAttendeesRequest(new CharacterIdEventIdRouteModel(characterId, eventId));
            }
        }
        internal class SummaryCalendarEventsRequest : RouteModelBase<SummaryCalendarEventsUriModel>
        {
            private SummaryCalendarEventsRequest(SummaryCalendarEventsUriModel uriModel) : base(uriModel)
            { }

            public static SummaryCalendarEventsRequest Create(int characterId, int? fromEventId)
            {
                return new SummaryCalendarEventsRequest(new SummaryCalendarEventsUriModel(characterId, fromEventId));
            }
        }
        internal class CalendarRespondeRequest : RequestBase<CharacterIdEventIdRouteModel, CalendarRespondeBodyModel>
        {
            private CalendarRespondeRequest(CharacterIdEventIdRouteModel uriModel, CalendarRespondeBodyModel response) : base(uriModel, response)
            { }

            public static CalendarRespondeRequest Create(int characterId, int eventId, string response)
            {
                return new CalendarRespondeRequest(new CharacterIdEventIdRouteModel(characterId, eventId), new CalendarRespondeBodyModel(response));
            }
        }
    }

    internal class ContactRequests
    {
        internal class AddUpdateCharacterContactRequest : RequestBase<AddUpdateCharacterContactUriModel, ContactsIdsBodyModel>
        {
            private AddUpdateCharacterContactRequest(AddUpdateCharacterContactUriModel uriModel, ContactsIdsBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static AddUpdateCharacterContactRequest Create(int characterId, int[] contactIds, float standing, int[] labelIds, bool watched)
            {
                return new AddUpdateCharacterContactRequest(new AddUpdateCharacterContactUriModel(characterId, standing, labelIds, watched), new ContactsIdsBodyModel(contactIds));
            }
        }

        internal class DeleteCharacterContactsRequest : RouteModelBase<DeleteCharacterContactUriModel>
        {
            private DeleteCharacterContactsRequest(DeleteCharacterContactUriModel uriModel) : base(uriModel)
            { }

            public static DeleteCharacterContactsRequest Create(int characterId, int[] contactIds)
            {
                return new DeleteCharacterContactsRequest(new DeleteCharacterContactUriModel(characterId, contactIds));
            }
        }
    }

    internal class ContractRequests
    {
        internal class CharacterContractRouteRequest : RouteModelBase<CharacterContractRouteModel>
        {
            private CharacterContractRouteRequest(CharacterContractRouteModel uriModel) : base(uriModel)
            { }

            public static CharacterContractRouteRequest Create(int characterId, int contractId)
            {
                return new CharacterContractRouteRequest(new CharacterContractRouteModel(characterId, contractId));
            }
        }

        internal class PageBasedRegionIdRouteRequest : RouteModelBase<PageBasedRegionIdModel>
        {
            private PageBasedRegionIdRouteRequest(PageBasedRegionIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedRegionIdRouteRequest Create(int regionId, int page)
            {
                return new PageBasedRegionIdRouteRequest(new PageBasedRegionIdModel(regionId, page));
            }
        }

        internal class PageBasedContractIdRouteRequest : RouteModelBase<PageBasedContractIdModel>
        {
            private PageBasedContractIdRouteRequest(PageBasedContractIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedContractIdRouteRequest Create(int contractId, int page)
            {
                return new PageBasedContractIdRouteRequest(new PageBasedContractIdModel(contractId, page));
            }
        }

        internal class CorporationContractRouteRequest : RouteModelBase<CorporationContractRouteModel>
        {
            private CorporationContractRouteRequest(CorporationContractRouteModel uriModel) : base(uriModel)
            { }

            public static CorporationContractRouteRequest Create(int corporationId, int contractId)
            {
                return new CorporationContractRouteRequest(new CorporationContractRouteModel(corporationId, contractId));
            }
        }

        internal class PageBasedCorporationContractRouteRequest : RouteModelBase<CorporationContractPageBasedRouteModel>
        {
            private PageBasedCorporationContractRouteRequest(CorporationContractPageBasedRouteModel uriModel) : base(uriModel)
            { }

            public static PageBasedCorporationContractRouteRequest Create(int corporationId, int contractId, int page)
            {
                return new PageBasedCorporationContractRouteRequest(new CorporationContractPageBasedRouteModel(corporationId, contractId, page));
            }
        }
    }

    internal class CorporationRequests
    {
        internal class StarbaseInfoRequest : RouteModelBase<StarbaseInfoUriModel>
        {
            private StarbaseInfoRequest(StarbaseInfoUriModel uriModel) : base(uriModel)
            { }

            public static StarbaseInfoRequest Create(int corporationId, long starbaseId, int systemId)
            {
                return new StarbaseInfoRequest(new StarbaseInfoUriModel(corporationId, starbaseId, systemId));
            }
        }
    }

    internal class DogmaRequests
    {
        internal class AttributeIdRouteRequest : RouteModelBase<AttributeIdModel>
        {
            private AttributeIdRouteRequest(AttributeIdModel uriModel) : base(uriModel)
            { }

            public static AttributeIdRouteRequest Create(int attributeId)
            {
                return new AttributeIdRouteRequest(new AttributeIdModel(attributeId));
            }
        }

        internal class EffectIdRouteRequest : RouteModelBase<EffectIdModel>
        {
            private EffectIdRouteRequest(EffectIdModel uriModel) : base(uriModel)
            { }

            public static EffectIdRouteRequest Create(int effectId)
            {
                return new EffectIdRouteRequest(new EffectIdModel(effectId));
            }
        }

        internal class DynamicItemInfoRequest : RouteModelBase<DynamicItemInfoUriModel>
        {
            private DynamicItemInfoRequest(DynamicItemInfoUriModel uriModel) : base(uriModel)
            { }

            public static DynamicItemInfoRequest Create(long itemId, int typeId)
            {
                return new DynamicItemInfoRequest(new DynamicItemInfoUriModel(itemId, typeId));
            }
        }
    }

    internal class FittingsRequests
    {
        internal class DeleteFittingRequest : RouteModelBase<DeleteFittingUriModel>
        {
            private DeleteFittingRequest(DeleteFittingUriModel uriModel) : base(uriModel)
            { }

            public static DeleteFittingRequest Create(int characterId, int fittingId)
            {
                return new DeleteFittingRequest(new DeleteFittingUriModel(characterId, fittingId));
            }
        }

        internal class NewFittingRequest : RequestBase<CharacterIdModel, NewFittingBodyModel>
        {
            private NewFittingRequest(CharacterIdModel uriModel, NewFittingBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static NewFittingRequest Create(int characterId, NewFittingBodyModel fitting)
            {
                return new NewFittingRequest(new CharacterIdModel(characterId), fitting);
            }
        }
    }

    internal class FleetsRequests
    {
        internal class FleetIdRouteRequest : RouteModelBase<FleetIdModel>
        {
            private FleetIdRouteRequest(FleetIdModel uriModel) : base(uriModel)
            { }

            public static FleetIdRouteRequest Create(long fleetId)
            {
                return new FleetIdRouteRequest(new FleetIdModel(fleetId));
            }
        }

        internal class InviteFleetMemberRequest : RequestBase<FleetIdModel, InviteFleetMemberBodyModel>
        {
            private InviteFleetMemberRequest(FleetIdModel uriModel, InviteFleetMemberBodyModel body) : base(uriModel, body)
            { }

            public static InviteFleetMemberRequest Create(long fleetId, int characterId, string role, long? squadId, long? wingId)
            {
                return new InviteFleetMemberRequest(new FleetIdModel(fleetId), new InviteFleetMemberBodyModel(characterId, role, squadId, wingId));
            }
        }

        internal class UpdateFleetSettingsRequest : RequestBase<FleetIdModel, FleetSettingsBodyModel>
        {
            private UpdateFleetSettingsRequest(FleetIdModel uriModel, FleetSettingsBodyModel body) : base(uriModel, body)
            { }

            public static UpdateFleetSettingsRequest Create(long fleetId, bool? isFreeMove, string motd)
            {
                return new UpdateFleetSettingsRequest(new FleetIdModel(fleetId), new FleetSettingsBodyModel(isFreeMove, motd));
            }
        }

        internal class FleetMemberRouteRequest : RouteModelBase<FleetMemberUriModel>
        {
            private FleetMemberRouteRequest(FleetMemberUriModel uriModel) : base(uriModel)
            { }

            public static FleetMemberRouteRequest Create(long fleetId, int memberId)
            {
                return new FleetMemberRouteRequest(new FleetMemberUriModel(fleetId, memberId));
            }
        }

        internal class MoveFleetMemberRequest : RequestBase<FleetMemberUriModel, MoveFleetMemberBodyModel>
        {
            private MoveFleetMemberRequest(FleetMemberUriModel uriModel, MoveFleetMemberBodyModel body) : base(uriModel, body)
            { }

            public static MoveFleetMemberRequest Create(long fleetId, int memberId, string role, long? squadId, long? wingId)
            {
                return new MoveFleetMemberRequest(new FleetMemberUriModel(fleetId, memberId), new MoveFleetMemberBodyModel(role, squadId, wingId));
            }
        }

        internal class FleetWingRouteRequest : RouteModelBase<FleetWingUriModel>
        {
            private FleetWingRouteRequest(FleetWingUriModel uriModel) : base(uriModel)
            { }

            public static FleetWingRouteRequest Create(long fleetId, long wingId)
            {
                return new FleetWingRouteRequest(new FleetWingUriModel(fleetId, wingId));
            }
        }

        internal class FleetSquadRouteRequest : RouteModelBase<FleetSquadUriModel>
        {
            private FleetSquadRouteRequest(FleetSquadUriModel uriModel) : base(uriModel)
            { }

            public static FleetSquadRouteRequest Create(long fleetId, long squadId)
            {
                return new FleetSquadRouteRequest(new FleetSquadUriModel(fleetId, squadId));
            }
        }

        internal class RenameSquadRequest : RequestBase<FleetSquadUriModel, RenameBodyModel>
        {
            private RenameSquadRequest(FleetSquadUriModel uriModel, RenameBodyModel body) : base(uriModel, body)
            { }

            public static RenameSquadRequest Create(long fleetId, long squadId, string name)
            {
                return new RenameSquadRequest(new FleetSquadUriModel(fleetId, squadId), new RenameBodyModel(name));
            }
        }

        internal class RenameWingRequest : RequestBase<FleetWingUriModel, RenameBodyModel>
        {
            private RenameWingRequest(FleetWingUriModel uriModel, RenameBodyModel body) : base(uriModel, body)
            { }

            public static RenameWingRequest Create(long fleetId, long wingId, string name)
            {
                return new RenameWingRequest(new FleetWingUriModel(fleetId, wingId), new RenameBodyModel(name));
            }
        }
    }

    internal class IndustryRequests
    {
        internal class CorporationObserverRequest : RouteModelBase<CorporationObserverUriModel>
        {
            private CorporationObserverRequest(CorporationObserverUriModel uriModel) : base(uriModel)
            { }

            public static CorporationObserverRequest Create(int corporationId, long observerId, int page)
            {
                return new CorporationObserverRequest(new CorporationObserverUriModel(corporationId, observerId, page));
            }
        }

        internal class CharacterJobsRequest : RouteModelBase<CharacterJobsUriModel>
        {
            private CharacterJobsRequest(CharacterJobsUriModel uriModel) : base(uriModel)
            { }

            public static CharacterJobsRequest Create(int characterId, bool includeCompleted)
            {
                return new CharacterJobsRequest(new CharacterJobsUriModel(characterId, includeCompleted));
            }
        }

        internal class CorporationJobsRequest : RouteModelBase<CorporationJobsUriModel>
        {
            private CorporationJobsRequest(CorporationJobsUriModel uriModel) : base(uriModel)
            { }

            public static CorporationJobsRequest Create(int corporation, bool includeCompleted, int page)
            {
                return new CorporationJobsRequest(new CorporationJobsUriModel(corporation, includeCompleted, page));
            }
        }
    }

    internal class KillmailsRequests
    {
        internal class KillmailInfoRequest : RouteModelBase<KillmailInfoUriModel>
        {
            private KillmailInfoRequest(KillmailInfoUriModel uriModel) : base(uriModel)
            { }

            public static KillmailInfoRequest Create(int killmailId, string killmailHash)
            {
                return new KillmailInfoRequest(new KillmailInfoUriModel(killmailId, killmailHash));
            }
        }
    }

    internal class MailRequests
    {
        internal class GetMailHeaderseRequest : RouteModelBase<MailHeadersUriModel>
        {
            private GetMailHeaderseRequest(MailHeadersUriModel uriModel) : base(uriModel)
            { }

            public static GetMailHeaderseRequest Create(int characterId, int[] labels, int? lastMailId)
            {
                return new GetMailHeaderseRequest(new MailHeadersUriModel(characterId, labels, lastMailId));
            }
        }

        internal class GetDeleteMailRequest : RouteModelBase<GetDeleteUpdateMailUriModel>
        {
            private GetDeleteMailRequest(GetDeleteUpdateMailUriModel uriModel) : base(uriModel)
            { }

            public static GetDeleteMailRequest Create(int characterId, int mailId)
            {
                return new GetDeleteMailRequest(new GetDeleteUpdateMailUriModel(characterId, mailId));
            }
        }

        internal class DeleteLabelRequest : RouteModelBase<DeleteLabelUriModel>
        {
            private DeleteLabelRequest(DeleteLabelUriModel uriModel) : base(uriModel)
            { }

            public static DeleteLabelRequest Create(int characterId, int labelId)
            {
                return new DeleteLabelRequest(new DeleteLabelUriModel(characterId, labelId));
            }
        }

        internal class NewLabelRequest : RequestBase<CharacterIdModel, NewLabelBodyModel>
        {
            private NewLabelRequest(CharacterIdModel uriModel, NewLabelBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static NewLabelRequest Create(int characterId, string color, string name)
            {
                return new NewLabelRequest(new CharacterIdModel(characterId), new NewLabelBodyModel(name, color));
            }
        }

        internal class UpdateMailRequest : RequestBase<GetDeleteUpdateMailUriModel, UpdateMailBodyModel>
        {
            private UpdateMailRequest(GetDeleteUpdateMailUriModel uriModel, UpdateMailBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static UpdateMailRequest Create(int characterId, int mailId, int[] labels, bool? read)
            {
                return new UpdateMailRequest(new GetDeleteUpdateMailUriModel(characterId, mailId), new UpdateMailBodyModel(labels, read));
            }
        }

        internal class NewMailRequest : RequestBase<CharacterIdModel, NewMailBodyModel>
        {
            private NewMailRequest(CharacterIdModel uriModel, NewMailBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static NewMailRequest Create(int characterId, NewMailBodyModel bodyModel)
            {
                return new NewMailRequest(new CharacterIdModel(characterId), bodyModel);
            }
        }
    }

    internal class MarketRequests
    {
        internal class RegionStatisticsRouteRequest : RouteModelBase<RegionStatisticsUriModel>
        {
            private RegionStatisticsRouteRequest(RegionStatisticsUriModel uriModel) : base(uriModel)
            { }

            public static RegionStatisticsRouteRequest Create(int regionId, int typeId)
            {
                return new RegionStatisticsRouteRequest(new RegionStatisticsUriModel(regionId, typeId));
            }
        }

        internal class MarketGroupInfoRequest : RouteModelBase<MarketGroupUriModel>
        {
            private MarketGroupInfoRequest(MarketGroupUriModel uriModel) : base(uriModel)
            { }

            public static MarketGroupInfoRequest Create(int marketGroupId)
            {
                return new MarketGroupInfoRequest(new MarketGroupUriModel(marketGroupId));
            }
        }

        internal class PageBasedRegionIdRouteRequest : RouteModelBase<PageBasedRegionIdModel>
        {
            private PageBasedRegionIdRouteRequest(PageBasedRegionIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedRegionIdRouteRequest Create(int regionId, int page)
            {
                return new PageBasedRegionIdRouteRequest(new PageBasedRegionIdModel(regionId, page));
            }
        }

        internal class PageBasedStructureIdRouteRequest : RouteModelBase<PageBasedStructureIdModel>
        {
            private PageBasedStructureIdRouteRequest(PageBasedStructureIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedStructureIdRouteRequest Create(long structureId, int page)
            {
                return new PageBasedStructureIdRouteRequest(new PageBasedStructureIdModel(structureId, page));
            }
        }

        internal class RegionOrdersRequest : RouteModelBase<RegionOrdersUriModel>
        {
            private RegionOrdersRequest(RegionOrdersUriModel uriModel) : base(uriModel)
            { }

            public static RegionOrdersRequest Create(int regionId, string orderType, int? typeId, int page)
            {
                return new RegionOrdersRequest(new RegionOrdersUriModel(regionId, orderType, typeId, page));
            }
        }
    }

    internal class OpportunitiesRequests
    {
        internal class GroupIdRouteRequest : RouteModelBase<OpportunitiesGroupIdModel>
        {
            private GroupIdRouteRequest(OpportunitiesGroupIdModel uriModel) : base(uriModel)
            { }

            public static GroupIdRouteRequest Create(int groupId)
            {
                return new GroupIdRouteRequest(new OpportunitiesGroupIdModel(groupId));
            }
        }

        internal class TaskIdRouteRequest : RouteModelBase<OpportunitiesTaskIdModel>
        {
            private TaskIdRouteRequest(OpportunitiesTaskIdModel uriModel) : base(uriModel)
            { }

            public static TaskIdRouteRequest Create(int taskId)
            {
                return new TaskIdRouteRequest(new OpportunitiesTaskIdModel(taskId));
            }
        }
    }

    internal class PlanetaryInteractionRequests
    {
        internal class ColonyInfoRequest : RouteModelBase<ColonyInfoUriModel>
        {
            private ColonyInfoRequest(ColonyInfoUriModel uriModel) : base(uriModel)
            { }

            public static ColonyInfoRequest Create(int characterId, int planetId)
            {
                return new ColonyInfoRequest(new ColonyInfoUriModel(characterId, planetId));
            }
        }

        internal class SchematicInfoRequest : RouteModelBase<SchematicIdModel>
        {
            private SchematicInfoRequest(SchematicIdModel uriModel) : base(uriModel)
            { }

            public static SchematicInfoRequest Create(int schematicId)
            {
                return new SchematicInfoRequest(new SchematicIdModel(schematicId));
            }
        }
    }

    internal class RoutesRequests
    {
        internal class RouteRequest : RouteModelBase<RoutesUriModels>
        {
            private RouteRequest(RoutesUriModels uriModel) : base(uriModel)
            { }

            public static RouteRequest Create(int origin, int destination, string flag, int[] avoid, int[] connetions)
            {
                return new RouteRequest(new RoutesUriModels(origin, destination, flag, avoid, connetions));
            }
        }
    }

    internal class SearchRequests
    {
        internal class SearchRequest : RouteModelBase<SearchQueryUriModel>
        {
            private SearchRequest(SearchQueryUriModel uriModel) : base(uriModel)
            { }

            public static SearchRequest Create(int characterId, string search, string categories, bool strict)
            {
                return new SearchRequest(new SearchQueryUriModel(characterId, search, categories, strict));
            }
        }
    }

    internal class UniverseRequests
    {
        internal class AsteroidBeltRequest : RouteModelBase<AsteroidBeltIdModel>
        {
            private AsteroidBeltRequest(AsteroidBeltIdModel uriModel) : base(uriModel)
            { }

            public static AsteroidBeltRequest Create(int asteroidBeltId)
            {
                return new AsteroidBeltRequest(new AsteroidBeltIdModel(asteroidBeltId));
            }
        }

        internal class ConstellationRequest : RouteModelBase<ConstellationIdModel>
        {
            private ConstellationRequest(ConstellationIdModel uriModel) : base(uriModel)
            { }

            public static ConstellationRequest Create(int constellationId)
            {
                return new ConstellationRequest(new ConstellationIdModel(constellationId));
            }
        }

        internal class GraphicRequest : RouteModelBase<GraphicIdModel>
        {
            private GraphicRequest(GraphicIdModel uriModel) : base(uriModel)
            { }

            public static GraphicRequest Create(int graphicId)
            {
                return new GraphicRequest(new GraphicIdModel(graphicId));
            }
        }

        internal class StructureInfoRequest : RouteModelBase<StructureIdModel>
        {
            private StructureInfoRequest(StructureIdModel uriModel) : base(uriModel)
            { }

            public static StructureInfoRequest Create(long structureid)
            {
                return new StructureInfoRequest(new StructureIdModel(structureid));
            }
        }

        internal class RegionInfoRequest : RouteModelBase<RegionIdModel>
        {
            private RegionInfoRequest(RegionIdModel uriModel) : base(uriModel)
            { }

            public static RegionInfoRequest Create(int regionId)
            {
                return new RegionInfoRequest(new RegionIdModel(regionId));
            }
        }

        internal class StructuresRequest : RouteModelBase<StructureTypeModel>
        {
            private StructuresRequest(StructureTypeModel uriModel) : base(uriModel)
            { }

            public static StructuresRequest Create(string filter)
            {
                return new StructuresRequest(new StructureTypeModel(filter));
            }
        }

        internal class TypeInfoRequest : RouteModelBase<TypeIdModel>
        {
            private TypeInfoRequest(TypeIdModel uriModel) : base(uriModel)
            { }

            public static TypeInfoRequest Create(int typeId)
            {
                return new TypeInfoRequest(new TypeIdModel(typeId));
            }
        }

        internal class StationInfoRequest : RouteModelBase<StationIdModel>
        {
            private StationInfoRequest(StationIdModel uriModel) : base(uriModel)
            { }

            public static StationInfoRequest Create(int stationId)
            {
                return new StationInfoRequest(new StationIdModel(stationId));
            }
        }

        internal class StarInfoRequest : RouteModelBase<StarIdModel>
        {
            private StarInfoRequest(StarIdModel uriModel) : base(uriModel)
            { }

            public static StarInfoRequest Create(int starId)
            {
                return new StarInfoRequest(new StarIdModel(starId));
            }
        }

        internal class StargateInfoRequest : RouteModelBase<StargateIdModel>
        {
            private StargateInfoRequest(StargateIdModel uriModel) : base(uriModel)
            { }

            public static StargateInfoRequest Create(int stargateId)
            {
                return new StargateInfoRequest(new StargateIdModel(stargateId));
            }
        }

        internal class SolarSystemInfoRequest : RouteModelBase<SolarSystemIdModel>
        {
            private SolarSystemInfoRequest(SolarSystemIdModel uriModel) : base(uriModel)
            { }

            public static SolarSystemInfoRequest Create(int systemId)
            {
                return new SolarSystemInfoRequest(new SolarSystemIdModel(systemId));
            }
        }

        internal class PlanetInfoRequest : RouteModelBase<PlanetIdModel>
        {
            private PlanetInfoRequest(PlanetIdModel uriModel) : base(uriModel)
            { }

            public static PlanetInfoRequest Create(int planetId)
            {
                return new PlanetInfoRequest(new PlanetIdModel(planetId));
            }
        }

        internal class MoonInfoRequest : RouteModelBase<MoonIdModel>
        {
            private MoonInfoRequest(MoonIdModel uriModel) : base(uriModel)
            { }

            public static MoonInfoRequest Create(int moonId)
            {
                return new MoonInfoRequest(new MoonIdModel(moonId));
            }
        }

        internal class ItemGroupInfoRequest : RouteModelBase<ItemGroupIdModel>
        {
            private ItemGroupInfoRequest(ItemGroupIdModel uriModel) : base(uriModel)
            { }

            public static ItemGroupInfoRequest Create(int groupId)
            {
                return new ItemGroupInfoRequest(new ItemGroupIdModel(groupId));
            }
        }

        internal class ItemCategoryInfoRequest : RouteModelBase<ItemCategoryIdModel>
        {
            private ItemCategoryInfoRequest(ItemCategoryIdModel uriModel) : base(uriModel)
            { }

            public static ItemCategoryInfoRequest Create(int categoryId)
            {
                return new ItemCategoryInfoRequest(new ItemCategoryIdModel(categoryId));
            }
        }

        internal class IDsRequest : BodyModelBase<string[]>
        {
            private IDsRequest(string[] bodyModel) : base(bodyModel)
            { }

            public static IDsRequest Create(string[] names)
            {
                return new IDsRequest(names);
            }
        }

        internal class NamesRequest : BodyModelBase<int[]>
        {
            private NamesRequest(int[] bodyModel) : base(bodyModel)
            { }

            public static NamesRequest Create(int[] ids)
            {
                return new NamesRequest(ids);
            }
        }
    }

    internal class UserInterfaceRequests
    {
        internal class OpenContractWindowRequest : RouteModelBase<OpenContractWindowModel>
        {
            private OpenContractWindowRequest(OpenContractWindowModel uriModel) : base(uriModel)
            { }

            public static OpenContractWindowRequest Create(int contractId)
            {
                return new OpenContractWindowRequest(new OpenContractWindowModel(contractId));
            }
        }

        internal class OpenInformationWindowRequest : RouteModelBase<OpenInformationWindowModel>
        {
            private OpenInformationWindowRequest(OpenInformationWindowModel uriModel) : base(uriModel)
            { }

            public static OpenInformationWindowRequest Create(int targetId)
            {
                return new OpenInformationWindowRequest(new OpenInformationWindowModel(targetId));
            }
        }

        internal class OpenMarketDetailsRequest : RouteModelBase<OpenMarketDetailsModel>
        {
            private OpenMarketDetailsRequest(OpenMarketDetailsModel uriModel) : base(uriModel)
            { }

            public static OpenMarketDetailsRequest Create(int typeId)
            {
                return new OpenMarketDetailsRequest(new OpenMarketDetailsModel(typeId));
            }
        }

        internal class SetAutopilotWaypointRequest : RouteModelBase<SetAutopilotWaypointModel>
        {
            private SetAutopilotWaypointRequest(SetAutopilotWaypointModel uriModel) : base(uriModel)
            { }

            public static SetAutopilotWaypointRequest Create(long destinationId, bool addToBeginning, bool clearOtherWaypoints)
            {
                return new SetAutopilotWaypointRequest(new SetAutopilotWaypointModel(destinationId, addToBeginning, clearOtherWaypoints));
            }
        }

        internal class OpenNewMailWindowBodyRequest : BodyModelBase<OpenNewMailWindowBodyModel>
        {
            private OpenNewMailWindowBodyRequest(OpenNewMailWindowBodyModel uriModel) : base(uriModel)
            { }

            public static OpenNewMailWindowBodyRequest Create(string body, string subject, int[] recipients, int? toCorpOrAllianceId, int? toMailingListId)
            {
                return new OpenNewMailWindowBodyRequest(new OpenNewMailWindowBodyModel(body, subject, recipients, toCorpOrAllianceId, toMailingListId));
            }
        }
    }

    internal class WalletRequests
    {
        internal class CorporationWalletJournalRequest : RouteModelBase<CorporationWalletJournalModel>
        {
            private CorporationWalletJournalRequest(CorporationWalletJournalModel uriModel) : base(uriModel)
            { }

            public static CorporationWalletJournalRequest Create(int corporationId, int divisionId, int page)
            {
                return new CorporationWalletJournalRequest(new CorporationWalletJournalModel(corporationId, divisionId, page));
            }
        }

        internal class CorporationWalletTransactionsRequest : RouteModelBase<CorporationWalletTransactionsModel>
        {
            private CorporationWalletTransactionsRequest(CorporationWalletTransactionsModel uriModel) : base(uriModel)
            { }

            public static CorporationWalletTransactionsRequest Create(int corporationId, int divisionId, long? fromId)
            {
                return new CorporationWalletTransactionsRequest(new CorporationWalletTransactionsModel(corporationId, divisionId, fromId));
            }
        }

        internal class WalletTransactionsRequest : RouteModelBase<WalletTransactionsModel>
        {
            private WalletTransactionsRequest(WalletTransactionsModel uriModel) : base(uriModel)
            { }

            public static WalletTransactionsRequest Create(int characterId, long? fromId)
            {
                return new WalletTransactionsRequest(new WalletTransactionsModel(characterId, fromId));
            }
        }
    }

    internal class WarsRequests
    {
        internal class WarsRequest : RouteModelBase<WarsModel>
        {
            private WarsRequest(WarsModel uriModel) : base(uriModel)
            { }

            public static WarsRequest Create(long? maxWarId)
            {
                return new WarsRequest(new WarsModel(maxWarId));
            }
        }

        internal class WarDetailsRequest : RouteModelBase<WarDetailsModel>
        {
            private WarDetailsRequest(WarDetailsModel uriModel) : base(uriModel)
            { }

            public static WarDetailsRequest Create(int warId)
            {
                return new WarDetailsRequest(new WarDetailsModel(warId));
            }
        }

        internal class KillsRequest : RouteModelBase<KillsModel>
        {
            private KillsRequest(KillsModel uriModel) : base(uriModel)
            { }

            public static KillsRequest Create(int warId, int page)
            {
                return new KillsRequest(new KillsModel(warId, page));
            }
        }
    }
}
