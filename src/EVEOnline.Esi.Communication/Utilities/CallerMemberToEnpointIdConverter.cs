using System.Collections.Generic;

namespace EVEOnline.Esi.Communication.Utilities
{
    internal static class CallerMemberToEnpointIdConverter
    {
        private static readonly Dictionary<string, string> _dataset;

        static CallerMemberToEnpointIdConverter()
        { 
            _dataset = new Dictionary<string, string>
            {
                { nameof(ICharacterLogic.GetCharacterPulicInformationAsync), ESI.Endpoints.Characters.PublicInformation },
                { nameof(ICharacterLogic.GetCharacterStandingsAsync), ESI.Endpoints.Characters.Standings },
                { nameof(ICharacterLogic.GetCharacterAgentsResearchAsync), ESI.Endpoints.Characters.AgentsResearch },
                { nameof(ICharacterLogic.GetCharacterBlueprintsAsync), ESI.Endpoints.Characters.Blueprints },
                { nameof(ICharacterLogic.GetCharacterCorporationHistoryAsync), ESI.Endpoints.Characters.CorporationHistory },
                { nameof(ICharacterLogic.PostCharacterCspaAsync), ESI.Endpoints.Characters.CSPA },
                { nameof(ICharacterLogic.GetCharacterFatigueAsync), ESI.Endpoints.Characters.Fatigue },
                { nameof(ICharacterLogic.GetCharacterMedalsAsync), ESI.Endpoints.Characters.Medals },
                { nameof(ICharacterLogic.GetCharacterNotificationsAsync), ESI.Endpoints.Characters.Notifications },
                { nameof(ICharacterLogic.GetCharacterContactNotificationsAsync), ESI.Endpoints.Characters.ContactNotifications },
                { nameof(ICharacterLogic.GetCharacterPulicInformationAsync), ESI.Endpoints.Characters.Portrait },
                { nameof(ICharacterLogic.GetCharacterRolesAsync), ESI.Endpoints.Characters.Roles },
                { nameof(ICharacterLogic.GetCharacterTitlesAsync), ESI.Endpoints.Characters.Titles },
                { nameof(ICharacterLogic.PostCharacterAffilationAsync), ESI.Endpoints.Characters.Affilation },

                { nameof(IAllianceLogic.GetAlliancesAsync), ESI.Endpoints.Alliances.AllianceList },
                { nameof(IAllianceLogic.GetAlliancePublicInformationAsync), ESI.Endpoints.Alliances.PublicInformation },
                { nameof(IAllianceLogic.GetAllianceCorporationsAsync), ESI.Endpoints.Alliances.CorporationsInAlliance },
                { nameof(IAllianceLogic.GetAllianceIconAsync), ESI.Endpoints.Alliances.AllianceIcon },

                { nameof(IAssetsLogic.GetCharacterAssets), ESI.Endpoints.Assets.CharacterAssetList },
                { nameof(IAssetsLogic.PostCharacterLocationAssets), ESI.Endpoints.Assets.LocationAssets },
                { nameof(IAssetsLogic.PostCharacterNameAssets), ESI.Endpoints.Assets.AssetItemNames },
                { nameof(IAssetsLogic.GetCorporationAssets), ESI.Endpoints.Assets.CorporationAssetList },
                { nameof(IAssetsLogic.PostCorporationLocationAssets), ESI.Endpoints.Assets.CorporationLocationAssets },
                { nameof(IAssetsLogic.PostCorporationNameAssets), ESI.Endpoints.Assets.CorporationAssetItemNames },

                { nameof(IBookmarksLogic.GetCharacterBookmarksAsync), ESI.Endpoints.Bookmarks.CharacterBookmarkList },
                { nameof(IBookmarksLogic.GetCharacterBookmarkFoldersAsync), ESI.Endpoints.Bookmarks.CharacterBookmarkFolderList },
                { nameof(IBookmarksLogic.GetCorporationBookmarksAsync), ESI.Endpoints.Bookmarks.CorporationBookmarkList },
                { nameof(IBookmarksLogic.GetCorporationBookmarkFoldersAsync), ESI.Endpoints.Bookmarks.CorporationBookmarkFolderList },

                { nameof(ICalendarLogic.GetCharacterSummaryCalendarEventsAsync), ESI.Endpoints.Calendar.CalendarItems },
                { nameof(ICalendarLogic.GetCharacterCalendarEventAsync), ESI.Endpoints.Calendar.CalendarEvent },
                { nameof(ICalendarLogic.RespondCaracterEventAsync), ESI.Endpoints.Calendar.RespondeEvent },
                { nameof(ICalendarLogic.GetCalendarEventAttendeesAsync), ESI.Endpoints.Calendar.EventAttendees },

                { nameof(IClonesLogic.GetCharacterClonesAsync), ESI.Endpoints.Clones.CloneList },
                { nameof(IClonesLogic.GetCharacterCloneImplantsAsync), ESI.Endpoints.Clones.CloneImplants },

                { nameof(IContactsLogic.GetAllianceContactsAsync), ESI.Endpoints.Contacts.AllianceContactList },
                { nameof(IContactsLogic.GetAllianceContactLabelsAsync), ESI.Endpoints.Contacts.AllianceContactLabelList },
                { nameof(IContactsLogic.DeleteCharacterContactsAsync), ESI.Endpoints.Contacts.DeleteCharacterContacts },
                { nameof(IContactsLogic.GetCharacterContactsAsync), ESI.Endpoints.Contacts.CharacterContactList },
                { nameof(IContactsLogic.AddCharacterContacts), ESI.Endpoints.Contacts.AddCharacterContacts },
                { nameof(IContactsLogic.UpdateCharacterContacts), ESI.Endpoints.Contacts.UpdateCharacterContacts },
                { nameof(IContactsLogic.GetCharacterContactLabelsAsync), ESI.Endpoints.Contacts.CharacterContactLabelList },
                { nameof(IContactsLogic.GetCorporationContactsAsync), ESI.Endpoints.Contacts.CorporationContactList },
                { nameof(IContactsLogic.GetCorporationContactLabelsAsync), ESI.Endpoints.Contacts.CorporationContactLabelList }
            };
        }

        public static string ToEndpointId(string callerMember)
        { 
            return _dataset[callerMember];
        }
    }
}
