namespace EVEOnline.Esi.Communication
{
    public class ESI
    {
        internal static class EsiClientMethodNames
        {
            public const string GetRequest = "GetRequest";
            public const string GetRequestWithouRequestParameters = "GetRequestWithouRequestParameters";
            public const string GetPaginationRequest = "GetPaginationRequest";
            public const string GetPaginationRequestWithouRequestParameters = "GetPaginationRequestWithouRequestParameters";
            public const string PostRequest = "PostRequest";
            public const string PostNoContentRequest = "PostNoContentRequest";
            public const string PutNoContentRequest = "PutNoContentRequest";
            public const string DeleteNoContentRequest = "DeleteNoContentRequest";
        }

        //internal static class AvailableRoutes
        //{
        //    private static Dictionary<string, EndpointVersion> _dataset;

        //    internal static Dictionary<string, EndpointVersion> Routes => _dataset;
            
        //    static AvailableRoutes()
        //    {
        //        _dataset = new Dictionary<string, EndpointVersion>
        //        {
        //            { ESI.Endpoints.Characters.PublicInformation, EndpointVersion.V5 | EndpointVersion.Latest | EndpointVersion.Legacy | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Standings, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.AgentsResearch, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Blueprints, EndpointVersion.Latest | EndpointVersion.V3 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.CorporationHistory, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.CSPA, EndpointVersion.Latest | EndpointVersion.V5 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Fatigue, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Medals, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Notifications, EndpointVersion.Latest | EndpointVersion.V5 | EndpointVersion.V6 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.ContactNotifications, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Portrait, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.V3 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Roles, EndpointVersion.Latest | EndpointVersion.V3 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Titles, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
        //            { ESI.Endpoints.Characters.Affilation, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev }
        //        };
        //    }
        //}

        public static class Endpoints
        {
            public static class Characters
            {
                public const string PublicInformation = "get_characters_character_id";
                public const string Standings = "get_characters_character_id_standings";
                public const string AgentsResearch = "get_characters_character_id_agents_research";
                public const string Blueprints = "get_characters_character_id_blueprints";
                public const string CorporationHistory = "get_characters_character_id_corporationhistory";
                public const string CSPA = "post_characters_character_id_cspa";
                public const string Fatigue = "get_characters_character_id_fatigue";
                public const string Medals = "get_characters_character_id_medals";
                public const string Notifications = "get_characters_character_id_notifications";
                public const string ContactNotifications = "get_characters_character_id_notifications_contacts";
                public const string Portrait = "get_characters_character_id_portrait";
                public const string Roles = "get_characters_character_id_roles";
                public const string Titles = "get_characters_character_id_titles";
                public const string Affilation = "post_characters_affiliation";
            }

            public static class Alliances
            {
                public const string AllianceList = "get_alliance";
                public const string PublicInformation = "get_alliances_alliance_id";
                public const string CorporationsInAlliance = "get_alliances_alliance_id_corporations";
                public const string AllianceIcon = "get_alliances_alliance_id_icons";
            }

            public static class Assets 
            {
                public const string CharacterAssetList = "get_characters_character_id_assets";
                public const string LocationAssets = "post_characters_character_id_assets_locations";
                public const string AssetItemNames = "post_characters_character_id_assets_names";
                public const string CorporationAssetList = "get_corporations_corporation_id_assets";
                public const string CorporationLocationAssets = "post_corporations_corporation_id_assets_locations";
                public const string CorporationAssetItemNames = "post_corporations_corporation_id_assets_names";
            }

            public static class Bookmarks 
            {
                public const string CharacterBookmarkList = "get_characters_character_id_bookmarks";
                public const string CharacterBookmarkFolderList = "get_characters_character_id_bookmarks_folders";
                public const string CorporationBookmarkList = "get_corporations_corporation_id_bookmarks";
                public const string CorporationBookmarkFolderList = "get_corporations_corporation_id_bookmarks_folders";
            }

            public static class Calendar
            {
                public const string CalendarItems = "get_characters_character_id_calendar";
                public const string CalendarEvent = "get_characters_character_id_calendar_event_id";
                public const string RespondeEvent = "put_characters_character_id_calendar_event_id";
                public const string EventAttendees = "get_characters_character_id_calendar_event_id_attendees";
            }

            public static class Clones
            {
                public const string CloneList = "get_characters_character_id_clones";
                public const string CloneImplants = "get_characters_character_id_implants";
            }

            public static class Contacts
            {
                public const string AllianceContactList = "get_alliances_alliance_id_contacts";
                public const string AllianceContactLabelList = "get_alliances_alliance_id_contacts_labels";
                public const string DeleteCharacterContacts = "delete_characters_character_id_contacts";
                public const string CharacterContactList = "get_characters_character_id_contacts";
                public const string AddCharacterContacts = "post_characters_character_id_contacts";
                public const string UpdateCharacterContacts = "put_characters_character_id_contacts";
                public const string CharacterContactLabelList = "get_characters_character_id_contacts_labels";
                public const string CorporationContactList = "get_corporations_corporation_id_contacts";
                public const string CorporationContactLabelList = "get_corporations_corporation_id_contacts_labels";
            }
        }
    }
}
