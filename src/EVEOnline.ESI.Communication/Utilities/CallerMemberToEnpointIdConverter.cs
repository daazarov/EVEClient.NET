using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Utilities
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
                { nameof(IContactsLogic.GetCorporationContactLabelsAsync), ESI.Endpoints.Contacts.CorporationContactLabelList },

                { nameof(IContractsLogic.GetCharacterContractsAsync), ESI.Endpoints.Contracts.CharacterContracts },
                { nameof(IContractsLogic.GetCharacterContractBidsAsync), ESI.Endpoints.Contracts.CharacterContractBids },
                { nameof(IContractsLogic.GetCharacterContractItemsAsync), ESI.Endpoints.Contracts.CharacterContractItems },
                { nameof(IContractsLogic.GetPublicContractsAsync), ESI.Endpoints.Contracts.PublicContracts },
                { nameof(IContractsLogic.GetPublicContractBidsAsync), ESI.Endpoints.Contracts.PublicContractBids },
                { nameof(IContractsLogic.GetPublicContractItemsAsync), ESI.Endpoints.Contracts.PublicContractItems },
                { nameof(IContractsLogic.GetCorporationContractsAsync), ESI.Endpoints.Contracts.CorporationContracts },
                { nameof(IContractsLogic.GetCorporationContractsBidsAsync), ESI.Endpoints.Contracts.CorporationContractBids },
                { nameof(IContractsLogic.GetCorporationContractItemsAsync), ESI.Endpoints.Contracts.CorporationContractItems },

                { nameof(ICorporationLogic.GetCorporationInfoAsync), ESI.Endpoints.Corporation.Information },
                { nameof(ICorporationLogic.GetCorporationAllianceHistoryAsync), ESI.Endpoints.Corporation.AllianceHistory },
                { nameof(ICorporationLogic.GetCorporationBlueprintsAsync), ESI.Endpoints.Corporation.Blueprints },
                { nameof(ICorporationLogic.GetCorporationContainerLogsAsync), ESI.Endpoints.Corporation.ContainersLogs },
                { nameof(ICorporationLogic.GetCorporationDivisionsAsync), ESI.Endpoints.Corporation.Divisions },
                { nameof(ICorporationLogic.GetCorporationFacilitiesAsync), ESI.Endpoints.Corporation.Facilities },
                { nameof(ICorporationLogic.GetCorporationIconAsync), ESI.Endpoints.Corporation.Icons },
                { nameof(ICorporationLogic.GetCorporationMedalsAsync), ESI.Endpoints.Corporation.Medals },
                { nameof(ICorporationLogic.GetCorporationIssuedMedalsAsync), ESI.Endpoints.Corporation.IssuedMedals },
                { nameof(ICorporationLogic.GetCorporationMembersAsync), ESI.Endpoints.Corporation.Members },
                { nameof(ICorporationLogic.GetCorporationMemberLimitAsync), ESI.Endpoints.Corporation.MembersLimit },
                { nameof(ICorporationLogic.GetCorporationMemberTitlesAsync), ESI.Endpoints.Corporation.MembersTitles },
                { nameof(ICorporationLogic.GetCorporationMemberTrackingAsync), ESI.Endpoints.Corporation.MemberTracking },
                { nameof(ICorporationLogic.GetCorporationMemberRolesAsync), ESI.Endpoints.Corporation.Roles },
                { nameof(ICorporationLogic.GetCorporationMemberRolesHistoryAsync), ESI.Endpoints.Corporation.RolesHistory },
                { nameof(ICorporationLogic.GetCorporationShareholdersAsync), ESI.Endpoints.Corporation.Shareholders },
                { nameof(ICorporationLogic.GetCorporationStandingsAsync), ESI.Endpoints.Corporation.Standings },
                { nameof(ICorporationLogic.GetCorporationStarbasesAsync), ESI.Endpoints.Corporation.Starbases },
                { nameof(ICorporationLogic.GetStarbaseInfoAsync), ESI.Endpoints.Corporation.StarbaseInfo },
                { nameof(ICorporationLogic.GetCorporationStructuresAsync), ESI.Endpoints.Corporation.Structures },
                { nameof(ICorporationLogic.GetCorporationTitlesAsync), ESI.Endpoints.Corporation.Titles },
                { nameof(ICorporationLogic.GetNpcCorporationsAsync), ESI.Endpoints.Corporation.NpcCorporations },

                { nameof(IDogmaLogic.GetAttributesAsync), ESI.Endpoints.Dogma.Attributes },
                { nameof(IDogmaLogic.GetAttributeInfoAsync), ESI.Endpoints.Dogma.AttributeInfo },
                { nameof(IDogmaLogic.GetDynamicItemInfoAsync), ESI.Endpoints.Dogma.DynamicItemInfo },
                { nameof(IDogmaLogic.GetDogmaEffectsAsync), ESI.Endpoints.Dogma.Effects },
                { nameof(IDogmaLogic.GetDogmaEffectInfoAsync), ESI.Endpoints.Dogma.EffectInfo },

                { nameof(IFactionWarfareLogic.GetCharacterStatsAsync), ESI.Endpoints.FactionWarfare.CharacterStats},
                { nameof(IFactionWarfareLogic.GetCorporationStatsAsync), ESI.Endpoints.FactionWarfare.CorporationStats},
                { nameof(IFactionWarfareLogic.GetFactionsLeaderboardAsync), ESI.Endpoints.FactionWarfare.FactionsLeaderboard},
                { nameof(IFactionWarfareLogic.GetCorporationsLeaderboardAsync), ESI.Endpoints.FactionWarfare.CorporationsLeaderboard},
                { nameof(IFactionWarfareLogic.GetCaractersLeaderboardAsync), ESI.Endpoints.FactionWarfare.CaractersLeaderboard},
                { nameof(IFactionWarfareLogic.GetFactionsStatsAsync), ESI.Endpoints.FactionWarfare.FactionsStats},
                { nameof(IFactionWarfareLogic.OwnershipSystemOverviewAsync), ESI.Endpoints.FactionWarfare.OwnershipSystemOverview},
                { nameof(IFactionWarfareLogic.GetWarsAsync), ESI.Endpoints.FactionWarfare.Wars},

                { nameof(IFittingsLogic.GetCharacterFittingsAsync), ESI.Endpoints.Fittings.GetFittings },
                { nameof(IFittingsLogic.NewCharacterFittingAsync), ESI.Endpoints.Fittings.NewFitting },
                { nameof(IFittingsLogic.DeleteCharacterFittingAsync), ESI.Endpoints.Fittings.DeleteFitting },

                { nameof(IFleetsLogic.GetCharacterFleetAsync), ESI.Endpoints.Fleets.FleetInfo },
                { nameof(IFleetsLogic.GetFleetSettingsAsync), ESI.Endpoints.Fleets.FleetSettings },
                { nameof(IFleetsLogic.GetFleetMembersAsync), ESI.Endpoints.Fleets.FleetMembers },
                { nameof(IFleetsLogic.GetFleetWingsAsync), ESI.Endpoints.Fleets.InviteMember },
                { nameof(IFleetsLogic.CreateFleetWingAsync), ESI.Endpoints.Fleets.NewWing },
                { nameof(IFleetsLogic.CreateSquadAsync), ESI.Endpoints.Fleets.NewSquad },
                { nameof(IFleetsLogic.DeleteFleetWingAsync), ESI.Endpoints.Fleets.DeleteWing },
                { nameof(IFleetsLogic.DeleteSquadAsync), ESI.Endpoints.Fleets.DeleteSquad },
                { nameof(IFleetsLogic.RenameFleetWingAsync), ESI.Endpoints.Fleets.RenameWing },
                { nameof(IFleetsLogic.RenameSquadAsync), ESI.Endpoints.Fleets.RenameSquad },
                { nameof(IFleetsLogic.UpdateFleetSettingsAsync), ESI.Endpoints.Fleets.UpdateFleetSettings },
                { nameof(IFleetsLogic.MoveMemberAsync), ESI.Endpoints.Fleets.MoveMember },
                { nameof(IFleetsLogic.KickMemberAsync), ESI.Endpoints.Fleets.KickMember },
                { nameof(IFleetsLogic.InviteMemberAsync), ESI.Endpoints.Fleets.InviteMember },

                { nameof(IIncursionsLogic.GetIncursions), ESI.Endpoints.Incursions.IncursionList },

                { nameof(IIndustryLogic.GetCharacterInductryJobsAsync), ESI.Endpoints.Industry.CharacterJobs },
                { nameof(IIndustryLogic.GetCharacterMiningLedgerAsync), ESI.Endpoints.Industry.CharacterMiningLedger },
                { nameof(IIndustryLogic.GetCorporationExtractionTimersAsync), ESI.Endpoints.Industry.ExtractionTimers },
                { nameof(IIndustryLogic.GetCorporationInductryJobsAsync), ESI.Endpoints.Industry.CorporationJobs },
                { nameof(IIndustryLogic.GetCorporationObserverInfoAsync), ESI.Endpoints.Industry.ObserverInfo },
                { nameof(IIndustryLogic.GetCorporationObserversAsync), ESI.Endpoints.Industry.CorporationObservers },
                { nameof(IIndustryLogic.GetIndustryFacilitiesAsync), ESI.Endpoints.Industry.Facilities },
                { nameof(IIndustryLogic.GetSolarSystemCostIndicesAsync), ESI.Endpoints.Industry.SolarSystems }
            };
        }

        public static string ToEndpointId(string callerMember)
        { 
            return _dataset[callerMember];
        }
    }
}
