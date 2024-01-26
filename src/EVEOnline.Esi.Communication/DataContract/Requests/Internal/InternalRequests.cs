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

            public static CalendarRespondeRequest Create(int characterId, int eventId, EventResponse response)
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
}
