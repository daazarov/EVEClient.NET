using System;
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
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterPulicInformationAsync)), ESI.Endpoints.Characters.PublicInformation },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterStandingsAsync)), ESI.Endpoints.Characters.Standings },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterAgentsResearchAsync)), ESI.Endpoints.Characters.AgentsResearch },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterBlueprintsAsync)), ESI.Endpoints.Characters.Blueprints },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterCorporationHistoryAsync)), ESI.Endpoints.Characters.CorporationHistory },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.PostCharacterCspaAsync)), ESI.Endpoints.Characters.CSPA },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterFatigueAsync)), ESI.Endpoints.Characters.Fatigue },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterMedalsAsync)), ESI.Endpoints.Characters.Medals },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterNotificationsAsync)), ESI.Endpoints.Characters.Notifications },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterContactNotificationsAsync)), ESI.Endpoints.Characters.ContactNotifications },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterPortraitAsync)), ESI.Endpoints.Characters.Portrait },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterRolesAsync)), ESI.Endpoints.Characters.Roles },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.GetCharacterTitlesAsync)), ESI.Endpoints.Characters.Titles },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.PostCharacterAffilationAsync)), ESI.Endpoints.Characters.Affilation },

                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.GetAlliancesAsync)), ESI.Endpoints.Alliances.AllianceList },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.GetAlliancePublicInformationAsync)), ESI.Endpoints.Alliances.PublicInformation },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.GetAllianceCorporationsAsync)), ESI.Endpoints.Alliances.CorporationsInAlliance },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.GetAllianceIconAsync)), ESI.Endpoints.Alliances.AllianceIcon },

                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.GetCharacterAssets)), ESI.Endpoints.Assets.CharacterAssetList },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.PostCharacterLocationAssets)), ESI.Endpoints.Assets.LocationAssets },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.PostCharacterNameAssets)), ESI.Endpoints.Assets.AssetItemNames },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.GetCorporationAssets)), ESI.Endpoints.Assets.CorporationAssetList },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.PostCorporationLocationAssets)), ESI.Endpoints.Assets.CorporationLocationAssets },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.PostCorporationNameAssets)), ESI.Endpoints.Assets.CorporationAssetItemNames },

                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.GetCharacterBookmarksAsync)), ESI.Endpoints.Bookmarks.CharacterBookmarkList },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.GetCharacterBookmarkFoldersAsync)), ESI.Endpoints.Bookmarks.CharacterBookmarkFolderList },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.GetCorporationBookmarksAsync)), ESI.Endpoints.Bookmarks.CorporationBookmarkList },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.GetCorporationBookmarkFoldersAsync)), ESI.Endpoints.Bookmarks.CorporationBookmarkFolderList },

                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.GetCharacterSummaryCalendarEventsAsync)), ESI.Endpoints.Calendar.CalendarItems },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.GetCharacterCalendarEventAsync)), ESI.Endpoints.Calendar.CalendarEvent },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.RespondCaracterEventAsync)), ESI.Endpoints.Calendar.RespondeEvent },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.GetCalendarEventAttendeesAsync)), ESI.Endpoints.Calendar.EventAttendees },

                { Key(typeof(IClonesLogic), nameof(IClonesLogic.GetCharacterClonesAsync)), ESI.Endpoints.Clones.CloneList },
                { Key(typeof(IClonesLogic), nameof(IClonesLogic.GetCharacterCloneImplantsAsync)), ESI.Endpoints.Clones.CloneImplants },

                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetAllianceContactsAsync)), ESI.Endpoints.Contacts.AllianceContactList },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetAllianceContactLabelsAsync)), ESI.Endpoints.Contacts.AllianceContactLabelList },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.DeleteCharacterContactsAsync)), ESI.Endpoints.Contacts.DeleteCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetCharacterContactsAsync)), ESI.Endpoints.Contacts.CharacterContactList },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.AddCharacterContacts)), ESI.Endpoints.Contacts.AddCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.UpdateCharacterContacts)), ESI.Endpoints.Contacts.UpdateCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetCharacterContactLabelsAsync)), ESI.Endpoints.Contacts.CharacterContactLabelList },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetCorporationContactsAsync)), ESI.Endpoints.Contacts.CorporationContactList },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.GetCorporationContactLabelsAsync)), ESI.Endpoints.Contacts.CorporationContactLabelList },

                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCharacterContractsAsync)), ESI.Endpoints.Contracts.CharacterContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCharacterContractBidsAsync)), ESI.Endpoints.Contracts.CharacterContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCharacterContractItemsAsync)), ESI.Endpoints.Contracts.CharacterContractItems },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetPublicContractsAsync)), ESI.Endpoints.Contracts.PublicContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetPublicContractBidsAsync)), ESI.Endpoints.Contracts.PublicContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetPublicContractItemsAsync)), ESI.Endpoints.Contracts.PublicContractItems },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCorporationContractsAsync)), ESI.Endpoints.Contracts.CorporationContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCorporationContractsBidsAsync)), ESI.Endpoints.Contracts.CorporationContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.GetCorporationContractItemsAsync)), ESI.Endpoints.Contracts.CorporationContractItems },

                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationInfoAsync)), ESI.Endpoints.Corporation.Information },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationAllianceHistoryAsync)), ESI.Endpoints.Corporation.AllianceHistory },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationBlueprintsAsync)), ESI.Endpoints.Corporation.Blueprints },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationContainerLogsAsync)), ESI.Endpoints.Corporation.ContainersLogs },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationDivisionsAsync)), ESI.Endpoints.Corporation.Divisions },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationFacilitiesAsync)), ESI.Endpoints.Corporation.Facilities },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationIconAsync)), ESI.Endpoints.Corporation.Icons },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMedalsAsync)), ESI.Endpoints.Corporation.Medals },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationIssuedMedalsAsync)), ESI.Endpoints.Corporation.IssuedMedals },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMembersAsync)), ESI.Endpoints.Corporation.Members },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMemberLimitAsync)), ESI.Endpoints.Corporation.MembersLimit },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMemberTitlesAsync)), ESI.Endpoints.Corporation.MembersTitles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMemberTrackingAsync)), ESI.Endpoints.Corporation.MemberTracking },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMemberRolesAsync)), ESI.Endpoints.Corporation.Roles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationMemberRolesHistoryAsync)), ESI.Endpoints.Corporation.RolesHistory },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationShareholdersAsync)), ESI.Endpoints.Corporation.Shareholders },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationStandingsAsync)), ESI.Endpoints.Corporation.Standings },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationStarbasesAsync)), ESI.Endpoints.Corporation.Starbases },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetStarbaseInfoAsync)), ESI.Endpoints.Corporation.StarbaseInfo },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationStructuresAsync)), ESI.Endpoints.Corporation.Structures },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetCorporationTitlesAsync)), ESI.Endpoints.Corporation.Titles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.GetNpcCorporationsAsync)), ESI.Endpoints.Corporation.NpcCorporations },

                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.GetAttributesAsync)), ESI.Endpoints.Dogma.Attributes },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.GetAttributeInfoAsync)), ESI.Endpoints.Dogma.AttributeInfo },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.GetDynamicItemInfoAsync)), ESI.Endpoints.Dogma.DynamicItemInfo },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.GetDogmaEffectsAsync)), ESI.Endpoints.Dogma.Effects },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.GetDogmaEffectInfoAsync)), ESI.Endpoints.Dogma.EffectInfo },

                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetCharacterStatsAsync)), ESI.Endpoints.FactionWarfare.CharacterStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetCorporationStatsAsync)), ESI.Endpoints.FactionWarfare.CorporationStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetFactionsLeaderboardAsync)), ESI.Endpoints.FactionWarfare.FactionsLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetCorporationsLeaderboardAsync)), ESI.Endpoints.FactionWarfare.CorporationsLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetCaractersLeaderboardAsync)), ESI.Endpoints.FactionWarfare.CaractersLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetFactionsStatsAsync)), ESI.Endpoints.FactionWarfare.FactionsStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.OwnershipSystemOverviewAsync)), ESI.Endpoints.FactionWarfare.OwnershipSystemOverview},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.GetWarsAsync)), ESI.Endpoints.FactionWarfare.Wars},

                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.GetCharacterFittingsAsync)), ESI.Endpoints.Fittings.GetFittings },
                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.NewCharacterFittingAsync)), ESI.Endpoints.Fittings.NewFitting },
                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.DeleteCharacterFittingAsync)), ESI.Endpoints.Fittings.DeleteFitting },

                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.GetCharacterFleetAsync)), ESI.Endpoints.Fleets.FleetInfo },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.GetFleetSettingsAsync)), ESI.Endpoints.Fleets.FleetSettings },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.GetFleetMembersAsync)), ESI.Endpoints.Fleets.FleetMembers },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.GetFleetWingsAsync)), ESI.Endpoints.Fleets.InviteMember },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.CreateFleetWingAsync)), ESI.Endpoints.Fleets.NewWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.CreateSquadAsync)), ESI.Endpoints.Fleets.NewSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteFleetWingAsync)), ESI.Endpoints.Fleets.DeleteWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteSquadAsync)), ESI.Endpoints.Fleets.DeleteSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.RenameFleetWingAsync)), ESI.Endpoints.Fleets.RenameWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.RenameSquadAsync)), ESI.Endpoints.Fleets.RenameSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.UpdateFleetSettingsAsync)), ESI.Endpoints.Fleets.UpdateFleetSettings },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.MoveMemberAsync)), ESI.Endpoints.Fleets.MoveMember },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.KickMemberAsync)), ESI.Endpoints.Fleets.KickMember },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.InviteMemberAsync)), ESI.Endpoints.Fleets.InviteMember },

                { Key(typeof(IIncursionsLogic), nameof(IIncursionsLogic.GetIncursions)), ESI.Endpoints.Incursions.IncursionList },

                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCharacterInductryJobsAsync)), ESI.Endpoints.Industry.CharacterJobs },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCharacterMiningLedgerAsync)), ESI.Endpoints.Industry.CharacterMiningLedger },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCorporationExtractionTimersAsync)), ESI.Endpoints.Industry.ExtractionTimers },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCorporationInductryJobsAsync)), ESI.Endpoints.Industry.CorporationJobs },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCorporationObserverInfoAsync)), ESI.Endpoints.Industry.ObserverInfo },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetCorporationObserversAsync)), ESI.Endpoints.Industry.CorporationObservers },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetIndustryFacilitiesAsync)), ESI.Endpoints.Industry.Facilities },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.GetSolarSystemCostIndicesAsync)), ESI.Endpoints.Industry.SolarSystems },

                { Key(typeof(IInsuranceLogic), nameof(IInsuranceLogic.GetInsuranceLevelsAsync)), ESI.Endpoints.Insurence.InsuranceLevels },

                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.GetCharacterKillmails)), ESI.Endpoints.Killmails.CharacterKillmails },
                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.GetCorporationKillmails)), ESI.Endpoints.Killmails.CorporationKillmails },
                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.GetKillmainInfo)), ESI.Endpoints.Killmails.KillmailInfo },

                { Key(typeof(ILocationLogic), nameof(ILocationLogic.GetCharacterLocationAsync)), ESI.Endpoints.Location.CurrentLocation },
                { Key(typeof(ILocationLogic), nameof(ILocationLogic.GetCharacterOnlineAsync)), ESI.Endpoints.Location.Online },
                { Key(typeof(ILocationLogic), nameof(ILocationLogic.GetCharacterShipAsync)), ESI.Endpoints.Location.CurrentShip },

                { Key(typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.GetLoyaltyPoints)), ESI.Endpoints.Loyalty.LoyaltyPoints },
                { Key(typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.GetCorporationOffers)), ESI.Endpoints.Loyalty.CorporationOffers },

                { Key(typeof(IMailLogic), nameof(IMailLogic.GetCharacterMailHeaders)), ESI.Endpoints.Mail.MailHeaders },
                { Key(typeof(IMailLogic), nameof(IMailLogic.SendMail)), ESI.Endpoints.Mail.SendMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.GetMail)), ESI.Endpoints.Mail.GetMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.UpdateMail)), ESI.Endpoints.Mail.UpdateMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.DeleteMail)), ESI.Endpoints.Mail.DeleteMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.GetCharacterMailLabels)), ESI.Endpoints.Mail.GetLabels },
                { Key(typeof(IMailLogic), nameof(IMailLogic.NewMailLabel)), ESI.Endpoints.Mail.CreateLabel },
                { Key(typeof(IMailLogic), nameof(IMailLogic.DeleteLabel)), ESI.Endpoints.Mail.DeleteLabel },
                { Key(typeof(IMailLogic), nameof(IMailLogic.GetCharacterMailingList)), ESI.Endpoints.Mail.MailingList },

                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetCharacterOrders)), ESI.Endpoints.Market.CharacterOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetCharacterOrdersHistory)), ESI.Endpoints.Market.CharacterOrdersHistory },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetCorporationOrders)), ESI.Endpoints.Market.CorporationOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetCorporationOrdersHistory)), ESI.Endpoints.Market.CorporationOrdersHistory },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetRegionOrders)), ESI.Endpoints.Market.RegionOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetRegionStatistics)), ESI.Endpoints.Market.RegionStatistics },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetStructureOrders)), ESI.Endpoints.Market.StructureOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetItemGroups)), ESI.Endpoints.Market.MarketGroups },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetItemGroupInfo)), ESI.Endpoints.Market.MarketGroupInfo },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetPrices)), ESI.Endpoints.Market.TypePrices },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.GetActiveOrderTypes)), ESI.Endpoints.Market.ActiveRegionOrderTypes },

                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GetCharacterComplitedTasks)), ESI.Endpoints.Opportunities.CompletedTasks },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GetOpportunitiesGroups)), ESI.Endpoints.Opportunities.Groups },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GetOpportunitiesGroupInfo)), ESI.Endpoints.Opportunities.GroupInfo },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GetOpportunitiesTasks)), ESI.Endpoints.Opportunities.Tasks },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GetOpportunitiesTaskInfo)), ESI.Endpoints.Opportunities.TaskInfo },

                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.GetCharacterColonies)), ESI.Endpoints.PlanetaryInteraction.Colonies },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.GetColonyInfo)), ESI.Endpoints.PlanetaryInteraction.ColonyInfo },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.GetCorporationCustomOffices)), ESI.Endpoints.PlanetaryInteraction.CustomOffices },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.GetSchematicInfo)), ESI.Endpoints.PlanetaryInteraction.SchematicInfo },

                { Key(typeof(IRoutesLogic), nameof(IRoutesLogic.Route)), ESI.Endpoints.Routes.Route },

                { Key(typeof(ISearchLogic), nameof(ISearchLogic.Query)), ESI.Endpoints.Search.Query },

                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.GetCharacterAttributes)), ESI.Endpoints.Skills.Attributes },
                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.GetCharacterSkillQueue)), ESI.Endpoints.Skills.SkillQueue },
                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.GetCharacterSkills)), ESI.Endpoints.Skills.SkillDetails },

                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Campaigns)), ESI.Endpoints.Sovereignty.Campaigns },
                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.SolarSystems)), ESI.Endpoints.Sovereignty.SolarSystems },
                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Structures)), ESI.Endpoints.Sovereignty.Structures },

                { Key(typeof(IStatusLogic), nameof(IStatusLogic.ServerStatus)), ESI.Endpoints.Status.ServerStatus },
            };
        }

        public static string ToEndpointId(Type callingMemberType, string callerMember) => _dataset[Key(callingMemberType, callerMember)];

        private static string Key(Type callingMemberType, string callerMember) => $"{callingMemberType.Name}-{callerMember}";
    }
}
