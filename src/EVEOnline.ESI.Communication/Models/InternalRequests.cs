namespace EVEOnline.ESI.Communication.Models
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

    internal class BookmarkRequests
    {
        internal class PageBasedCharacterIdRouteRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            public PageBasedCharacterIdRouteRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCharacterIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedCharacterIdRouteRequest(new PageBasedCharacterIdModel(characterId, page));
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

    internal class CloneLogic
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

        internal class AllianceIdRouteRequest : RouteModelBase<AllianceIdModel>
        {
            public AllianceIdRouteRequest(AllianceIdModel uriModel) : base(uriModel)
            { }

            public static AllianceIdRouteRequest Create(int allianceId)
            {
                return new AllianceIdRouteRequest(new AllianceIdModel(allianceId));
            }
        }

        internal class CharacterIdRouteRequest : RouteModelBase<CharacterIdModel>
        {
            public CharacterIdRouteRequest(CharacterIdModel uriModel) : base(uriModel)
            { }

            public static CharacterIdRouteRequest Create(int characterId)
            {
                return new CharacterIdRouteRequest(new CharacterIdModel(characterId));
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

        internal class PageBasedCharacterIdRouteRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            public PageBasedCharacterIdRouteRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCharacterIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedCharacterIdRouteRequest(new PageBasedCharacterIdModel(characterId, page));
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

    internal class ContractRequests
    {
        internal class PageBasedCharacterIdRouteRequest : RouteModelBase<PageBasedCharacterIdModel>
        {
            public PageBasedCharacterIdRouteRequest(PageBasedCharacterIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCharacterIdRouteRequest Create(int characterId, int page)
            {
                return new PageBasedCharacterIdRouteRequest(new PageBasedCharacterIdModel(characterId, page));
            }
        }

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

        internal class PageBasedCorporationIdRouteRequest : RouteModelBase<PageBasedCorporationIdModel>
        {
            public PageBasedCorporationIdRouteRequest(PageBasedCorporationIdModel uriModel) : base(uriModel)
            { }

            public static PageBasedCorporationIdRouteRequest Create(int corporationId, int page)
            {
                return new PageBasedCorporationIdRouteRequest(new PageBasedCorporationIdModel(corporationId, page));
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
        internal class CorporationIdRouteRequest : RouteModelBase<CorporationIdModel>
        {
            public CorporationIdRouteRequest(CorporationIdModel uriModel) : base(uriModel)
            { }

            public static CorporationIdRouteRequest Create(int corporationId)
            {
                return new CorporationIdRouteRequest(new CorporationIdModel(corporationId));
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

    internal class FactionWarfareRequests
    {
        internal class CorporationIdRouteRequest : RouteModelBase<CorporationIdModel>
        {
            public CorporationIdRouteRequest(CorporationIdModel uriModel) : base(uriModel)
            { }

            public static CorporationIdRouteRequest Create(int corporationId)
            {
                return new CorporationIdRouteRequest(new CorporationIdModel(corporationId));
            }
        }

        internal class CharacterIdRouteRequest : RouteModelBase<CharacterIdModel>
        {
            public CharacterIdRouteRequest(CharacterIdModel uriModel) : base(uriModel)
            { }

            public static CharacterIdRouteRequest Create(int characterId)
            {
                return new CharacterIdRouteRequest(new CharacterIdModel(characterId));
            }
        }
    }

    internal class FittingsRequests
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
        internal class CharacterIdRouteRequest : RouteModelBase<CharacterIdModel>
        {
            public CharacterIdRouteRequest(CharacterIdModel uriModel) : base(uriModel)
            { }

            public static CharacterIdRouteRequest Create(int characterId)
            {
                return new CharacterIdRouteRequest(new CharacterIdModel(characterId));
            }
        }

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
}
