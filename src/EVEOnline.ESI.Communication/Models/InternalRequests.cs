﻿namespace EVEOnline.ESI.Communication.Models
{
    internal class CommonRequests
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

        internal class AllianceIdRouteRequest : RouteModelBase<AllianceIdModel>
        {
            public AllianceIdRouteRequest(AllianceIdModel uriModel) : base(uriModel)
            { }

            public static AllianceIdRouteRequest Create(int allianceId)
            {
                return new AllianceIdRouteRequest(new AllianceIdModel(allianceId));
            }
        }

        internal class CorporationIdRouteRequest : RouteModelBase<CorporationIdModel>
        {
            public CorporationIdRouteRequest(CorporationIdModel uriModel) : base(uriModel)
            { }

            public static CorporationIdRouteRequest Create(int corporationId)
            {
                return new CorporationIdRouteRequest(new CorporationIdModel(corporationId));
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

        internal class PageBasedAllianceIdRouteRequest : RouteModelBase<PageBasedAllianceIdModel>
        {
            public PageBasedAllianceIdRouteRequest(PageBasedAllianceIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedAllianceIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedAllianceIdRouteRequest(new PageBasedAllianceIdModel(characterId, page));
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
    
    internal class CharactersRequests
    {
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

        internal class CorporationItemsPostRequest : RequestBase<CorporationIdModel, AssertItemBodyModel>
        {
            public CorporationItemsPostRequest(CorporationIdModel uriModel, AssertItemBodyModel itemIds) : base(uriModel, itemIds)
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
            public CalendarEventRequest(CharacterIdEventIdRouteModel uriModel) : base(uriModel)
            { }

            public static CalendarEventRequest Create(int characterId, int eventId)
            {
                return new CalendarEventRequest(new CharacterIdEventIdRouteModel(characterId, eventId));
            }
        }
        internal class CalendarEventAttendeesRequest : RouteModelBase<CharacterIdEventIdRouteModel>
        {
            public CalendarEventAttendeesRequest(CharacterIdEventIdRouteModel uriModel) : base(uriModel)
            { }

            public static CalendarEventAttendeesRequest Create(int characterId, int eventId)
            {
                return new CalendarEventAttendeesRequest(new CharacterIdEventIdRouteModel(characterId, eventId));
            }
        }
        internal class SummaryCalendarEventsRequest : RouteModelBase<SummaryCalendarEventsUriModel>
        {
            public SummaryCalendarEventsRequest(SummaryCalendarEventsUriModel uriModel) : base(uriModel)
            { }

            public static SummaryCalendarEventsRequest Create(int characterId, int? fromEventId)
            {
                return new SummaryCalendarEventsRequest(new SummaryCalendarEventsUriModel(characterId, fromEventId));
            }
        }
        internal class CalendarRespondeRequest : RequestBase<CharacterIdEventIdRouteModel, CalendarRespondeBodyModel>
        {
            public CalendarRespondeRequest(CharacterIdEventIdRouteModel uriModel, CalendarRespondeBodyModel response) : base(uriModel, response)
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
            public AddUpdateCharacterContactRequest(AddUpdateCharacterContactUriModel uriModel, ContactsIdsBodyModel itemIds) : base(uriModel, itemIds)
            { }

            public static AddUpdateCharacterContactRequest Create(int characterId, int[] contactIds, float standing, int[] labelIds, bool watched)
            {
                return new AddUpdateCharacterContactRequest(new AddUpdateCharacterContactUriModel(characterId, standing, labelIds, watched), new ContactsIdsBodyModel(contactIds));
            }
        }

        internal class DeleteCharacterContactsRequest : RouteModelBase<DeleteCharacterContactUriModel>
        {
            public DeleteCharacterContactsRequest(DeleteCharacterContactUriModel uriModel) : base(uriModel)
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
            public CharacterContractRouteRequest(CharacterContractRouteModel uriModel) : base(uriModel)
            { }

            public static CharacterContractRouteRequest Create(int characterId, int contractId)
            {
                return new CharacterContractRouteRequest(new CharacterContractRouteModel(characterId, contractId));
            }
        }

        internal class PageBasedRegionIdRouteRequest : RouteModelBase<PageBasedRegionIdModel>
        {
            public PageBasedRegionIdRouteRequest(PageBasedRegionIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedRegionIdRouteRequest Create(int regionId, int page)
            {
                return new PageBasedRegionIdRouteRequest(new PageBasedRegionIdModel(regionId, page));
            }
        }

        internal class PageBasedContractIdRouteRequest : RouteModelBase<PageBasedContractIdModel>
        {
            public PageBasedContractIdRouteRequest(PageBasedContractIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedContractIdRouteRequest Create(int contractId, int page)
            {
                return new PageBasedContractIdRouteRequest(new PageBasedContractIdModel(contractId, page));
            }
        }

        internal class CorporationContractRouteRequest : RouteModelBase<CorporationContractRouteModel>
        {
            public CorporationContractRouteRequest(CorporationContractRouteModel uriModel) : base(uriModel)
            { }

            public static CorporationContractRouteRequest Create(int corporationId, int contractId)
            {
                return new CorporationContractRouteRequest(new CorporationContractRouteModel(corporationId, contractId));
            }
        }

        internal class PageBasedCorporationContractRouteRequest : RouteModelBase<CorporationContractPageBasedRouteModel>
        {
            public PageBasedCorporationContractRouteRequest(CorporationContractPageBasedRouteModel uriModel) : base(uriModel)
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
            public StarbaseInfoRequest(StarbaseInfoUriModel uriModel) : base(uriModel)
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
            public AttributeIdRouteRequest(AttributeIdModel uriModel) : base(uriModel)
            { }

            public static AttributeIdRouteRequest Create(int attributeId)
            {
                return new AttributeIdRouteRequest(new AttributeIdModel(attributeId));
            }
        }

        internal class EffectIdRouteRequest : RouteModelBase<EffectIdModel>
        {
            public EffectIdRouteRequest(EffectIdModel uriModel) : base(uriModel)
            { }

            public static EffectIdRouteRequest Create(int effectId)
            {
                return new EffectIdRouteRequest(new EffectIdModel(effectId));
            }
        }

        internal class DynamicItemInfoRequest : RouteModelBase<DynamicItemInfoUriModel>
        {
            public DynamicItemInfoRequest(DynamicItemInfoUriModel uriModel) : base(uriModel)
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
            public DeleteFittingRequest(DeleteFittingUriModel uriModel) : base(uriModel)
            { }

            public static DeleteFittingRequest Create(int characterId, int fittingId)
            {
                return new DeleteFittingRequest(new DeleteFittingUriModel(characterId, fittingId));
            }
        }

        internal class NewFittingRequest : RequestBase<CharacterIdModel, NewFittingBodyModel>
        {
            public NewFittingRequest(CharacterIdModel uriModel, NewFittingBodyModel bodyModel) : base(uriModel, bodyModel)
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
            public FleetIdRouteRequest(FleetIdModel uriModel) : base(uriModel)
            { }

            public static FleetIdRouteRequest Create(long fleetId)
            {
                return new FleetIdRouteRequest(new FleetIdModel(fleetId));
            }
        }

        internal class InviteFleetMemberRequest : RequestBase<FleetIdModel, InviteFleetMemberBodyModel>
        {
            public InviteFleetMemberRequest(FleetIdModel uriModel, InviteFleetMemberBodyModel body) : base(uriModel, body)
            { }

            public static InviteFleetMemberRequest Create(long fleetId, int characterId, string role, long? squadId, long? wingId)
            {
                return new InviteFleetMemberRequest(new FleetIdModel(fleetId), new InviteFleetMemberBodyModel(characterId, role, squadId, wingId));
            }
        }

        internal class UpdateFleetSettingsRequest : RequestBase<FleetIdModel, FleetSettingsBodyModel>
        {
            public UpdateFleetSettingsRequest(FleetIdModel uriModel, FleetSettingsBodyModel body) : base(uriModel, body)
            { }

            public static UpdateFleetSettingsRequest Create(long fleetId, bool? isFreeMove, string motd)
            {
                return new UpdateFleetSettingsRequest(new FleetIdModel(fleetId), new FleetSettingsBodyModel(isFreeMove, motd));
            }
        }

        internal class FleetMemberRouteRequest : RouteModelBase<FleetMemberUriModel>
        {
            public FleetMemberRouteRequest(FleetMemberUriModel uriModel) : base(uriModel)
            { }

            public static FleetMemberRouteRequest Create(long fleetId, int memberId)
            {
                return new FleetMemberRouteRequest(new FleetMemberUriModel(fleetId, memberId));
            }
        }

        internal class MoveFleetMemberRequest : RequestBase<FleetMemberUriModel, MoveFleetMemberBodyModel>
        {
            public MoveFleetMemberRequest(FleetMemberUriModel uriModel, MoveFleetMemberBodyModel body) : base(uriModel, body)
            { }

            public static MoveFleetMemberRequest Create(long fleetId, int memberId, string role, long? squadId, long? wingId)
            {
                return new MoveFleetMemberRequest(new FleetMemberUriModel(fleetId, memberId), new MoveFleetMemberBodyModel(role, squadId, wingId));
            }
        }

        internal class FleetWingRouteRequest : RouteModelBase<FleetWingUriModel>
        {
            public FleetWingRouteRequest(FleetWingUriModel uriModel) : base(uriModel)
            { }

            public static FleetWingRouteRequest Create(long fleetId, long wingId)
            {
                return new FleetWingRouteRequest(new FleetWingUriModel(fleetId, wingId));
            }
        }

        internal class FleetSquadRouteRequest : RouteModelBase<FleetSquadUriModel>
        {
            public FleetSquadRouteRequest(FleetSquadUriModel uriModel) : base(uriModel)
            { }

            public static FleetSquadRouteRequest Create(long fleetId, long squadId)
            {
                return new FleetSquadRouteRequest(new FleetSquadUriModel(fleetId, squadId));
            }
        }

        internal class RenameSquadRequest : RequestBase<FleetSquadUriModel, RenameBodyModel>
        {
            public RenameSquadRequest(FleetSquadUriModel uriModel, RenameBodyModel body) : base(uriModel, body)
            { }

            public static RenameSquadRequest Create(long fleetId, long squadId, string name)
            {
                return new RenameSquadRequest(new FleetSquadUriModel(fleetId, squadId), new RenameBodyModel(name));
            }
        }

        internal class RenameWingRequest : RequestBase<FleetWingUriModel, RenameBodyModel>
        {
            public RenameWingRequest(FleetWingUriModel uriModel, RenameBodyModel body) : base(uriModel, body)
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
            public CorporationObserverRequest(CorporationObserverUriModel uriModel) : base(uriModel)
            { }

            public static CorporationObserverRequest Create(int corporationId, long observerId, int page)
            {
                return new CorporationObserverRequest(new CorporationObserverUriModel(corporationId, observerId, page));
            }
        }

        internal class CharacterJobsRequest : RouteModelBase<CharacterJobsUriModel>
        {
            public CharacterJobsRequest(CharacterJobsUriModel uriModel) : base(uriModel)
            { }

            public static CharacterJobsRequest Create(int characterId, bool includeCompleted)
            {
                return new CharacterJobsRequest(new CharacterJobsUriModel(characterId, includeCompleted));
            }
        }

        internal class CorporationJobsRequest : RouteModelBase<CorporationJobsUriModel>
        {
            public CorporationJobsRequest(CorporationJobsUriModel uriModel) : base(uriModel)
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
            public KillmailInfoRequest(KillmailInfoUriModel uriModel) : base(uriModel)
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
            public GetMailHeaderseRequest(MailHeadersUriModel uriModel) : base(uriModel)
            { }

            public static GetMailHeaderseRequest Create(int characterId, int[] labels, int? lastMailId)
            {
                return new GetMailHeaderseRequest(new MailHeadersUriModel(characterId, labels, lastMailId));
            }
        }

        internal class GetDeleteMailRequest : RouteModelBase<GetDeleteUpdateMailUriModel>
        {
            public GetDeleteMailRequest(GetDeleteUpdateMailUriModel uriModel) : base(uriModel)
            { }

            public static GetDeleteMailRequest Create(int characterId, int mailId)
            {
                return new GetDeleteMailRequest(new GetDeleteUpdateMailUriModel(characterId, mailId));
            }
        }

        internal class DeleteLabelRequest : RouteModelBase<DeleteLabelUriModel>
        {
            public DeleteLabelRequest(DeleteLabelUriModel uriModel) : base(uriModel)
            { }

            public static DeleteLabelRequest Create(int characterId, int labelId)
            {
                return new DeleteLabelRequest(new DeleteLabelUriModel(characterId, labelId));
            }
        }

        internal class NewLabelRequest : RequestBase<CharacterIdModel, NewLabelBodyModel>
        {
            public NewLabelRequest(CharacterIdModel uriModel, NewLabelBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static NewLabelRequest Create(int characterId, string color, string name)
            {
                return new NewLabelRequest(new CharacterIdModel(characterId), new NewLabelBodyModel(name, color));
            }
        }

        internal class UpdateMailRequest : RequestBase<GetDeleteUpdateMailUriModel, UpdateMailBodyModel>
        {
            public UpdateMailRequest(GetDeleteUpdateMailUriModel uriModel, UpdateMailBodyModel bodyModel) : base(uriModel, bodyModel)
            { }

            public static UpdateMailRequest Create(int characterId, int mailId, int[] labels, bool? read)
            {
                return new UpdateMailRequest(new GetDeleteUpdateMailUriModel(characterId, mailId), new UpdateMailBodyModel(labels, read));
            }
        }

        internal class NewMailRequest : RequestBase<CharacterIdModel, NewMailBodyModel>
        {
            public NewMailRequest(CharacterIdModel uriModel, NewMailBodyModel bodyModel) : base(uriModel, bodyModel)
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
            public RegionStatisticsRouteRequest(RegionStatisticsUriModel uriModel) : base(uriModel)
            { }

            public static RegionStatisticsRouteRequest Create(int regionId, int typeId)
            {
                return new RegionStatisticsRouteRequest(new RegionStatisticsUriModel(regionId, typeId));
            }
        }

        internal class MarketGroupInfoRequest : RouteModelBase<MarketGroupUriModel>
        {
            public MarketGroupInfoRequest(MarketGroupUriModel uriModel) : base(uriModel)
            { }

            public static MarketGroupInfoRequest Create(int marketGroupId)
            {
                return new MarketGroupInfoRequest(new MarketGroupUriModel(marketGroupId));
            }
        }

        internal class PageBasedRegionIdRouteRequest : RouteModelBase<PageBasedRegionIdModel>
        {
            public PageBasedRegionIdRouteRequest(PageBasedRegionIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedRegionIdRouteRequest Create(int regionId, int page)
            {
                return new PageBasedRegionIdRouteRequest(new PageBasedRegionIdModel(regionId, page));
            }
        }

        internal class PageBasedStructureIdRouteRequest : RouteModelBase<PageBasedStructureIdModel>
        {
            public PageBasedStructureIdRouteRequest(PageBasedStructureIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedStructureIdRouteRequest Create(long structureId, int page)
            {
                return new PageBasedStructureIdRouteRequest(new PageBasedStructureIdModel(structureId, page));
            }
        }

        internal class RegionOrdersRequest : RouteModelBase<RegionOrdersUriModel>
        {
            public RegionOrdersRequest(RegionOrdersUriModel uriModel) : base(uriModel)
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
            public GroupIdRouteRequest(OpportunitiesGroupIdModel uriModel) : base(uriModel)
            { }

            public static GroupIdRouteRequest Create(int groupId)
            {
                return new GroupIdRouteRequest(new OpportunitiesGroupIdModel(groupId));
            }
        }

        internal class TaskIdRouteRequest : RouteModelBase<OpportunitiesTaskIdModel>
        {
            public TaskIdRouteRequest(OpportunitiesTaskIdModel uriModel) : base(uriModel)
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
            public ColonyInfoRequest(ColonyInfoUriModel uriModel) : base(uriModel)
            { }

            public static ColonyInfoRequest Create(int characterId, int planetId)
            {
                return new ColonyInfoRequest(new ColonyInfoUriModel(characterId, planetId));
            }
        }

        internal class SchematicInfoRequest : RouteModelBase<SchematicIdModel>
        {
            public SchematicInfoRequest(SchematicIdModel uriModel) : base(uriModel)
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
            public RouteRequest(RoutesUriModels uriModel) : base(uriModel)
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
            public SearchRequest(SearchQueryUriModel uriModel) : base(uriModel)
            { }

            public static SearchRequest Create(int characterId, string search, string categories, bool strict)
            {
                return new SearchRequest(new SearchQueryUriModel(characterId, search, categories, strict));
            }
        }
    }
}
