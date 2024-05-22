using System;
using System.Collections.Generic;

namespace EVEOnline.ESI.Communication.Utilities
{
    internal static class CallerMemberToEnpointIdConverter
    {
        internal static readonly Dictionary<string, string> _dataset;

        static CallerMemberToEnpointIdConverter()
        { 
            _dataset = new Dictionary<string, string>
            {
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation)), ESI.Endpoints.Characters.PublicInformation },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Standings)), ESI.Endpoints.Characters.Standings },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.AgentsResearch)), ESI.Endpoints.Characters.AgentsResearch },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Blueprints)), ESI.Endpoints.Characters.Blueprints },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.CorporationHistory)), ESI.Endpoints.Characters.CorporationHistory },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.CSPA)), ESI.Endpoints.Characters.CSPA },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Fatigue)), ESI.Endpoints.Characters.Fatigue },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Medals)), ESI.Endpoints.Characters.Medals },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Notifications)), ESI.Endpoints.Characters.Notifications },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.ContactNotifications)), ESI.Endpoints.Characters.ContactNotifications },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Portrait)), ESI.Endpoints.Characters.Portrait },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Roles)), ESI.Endpoints.Characters.Roles },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Titles)), ESI.Endpoints.Characters.Titles },
                { Key(typeof(ICharacterLogic), nameof(ICharacterLogic.Affilation)), ESI.Endpoints.Characters.Affilation },

                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.ActiveAlliances)), ESI.Endpoints.Alliances.ActiveAlliances },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.PublicInformation)), ESI.Endpoints.Alliances.PublicInformation },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.CorporationsInAlliance)), ESI.Endpoints.Alliances.CorporationsInAlliance },
                { Key(typeof(IAllianceLogic), nameof(IAllianceLogic.AllianceIcon)), ESI.Endpoints.Alliances.AllianceIcon },

                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.CharacterAssetList)), ESI.Endpoints.Assets.CharacterAssetList },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.LocationAssets)), ESI.Endpoints.Assets.LocationAssets },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.AssetItemNames)), ESI.Endpoints.Assets.AssetItemNames },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationAssetList)), ESI.Endpoints.Assets.CorporationAssetList },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationLocationAssets)), ESI.Endpoints.Assets.CorporationLocationAssets },
                { Key(typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationAssetItemNames)), ESI.Endpoints.Assets.CorporationAssetItemNames },

                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.CharacterBookmarks)), ESI.Endpoints.Bookmarks.CharacterBookmarks },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.CharacterBookmarkFolders)), ESI.Endpoints.Bookmarks.CharacterBookmarkFolders },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.CorporationBookmarks)), ESI.Endpoints.Bookmarks.CorporationBookmarks },
                { Key(typeof(IBookmarksLogic), nameof(IBookmarksLogic.CorporationBookmarkFolders)), ESI.Endpoints.Bookmarks.CorporationBookmarkFolders },

                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.CalendarItems)), ESI.Endpoints.Calendar.CalendarItems },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.CalendarEvent)), ESI.Endpoints.Calendar.CalendarEvent },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.RespondeEvent)), ESI.Endpoints.Calendar.RespondeEvent },
                { Key(typeof(ICalendarLogic), nameof(ICalendarLogic.EventAttendees)), ESI.Endpoints.Calendar.EventAttendees },

                { Key(typeof(IClonesLogic), nameof(IClonesLogic.CloneList)), ESI.Endpoints.Clones.CloneList },
                { Key(typeof(IClonesLogic), nameof(IClonesLogic.CloneImplants)), ESI.Endpoints.Clones.CloneImplants },

                { Key(typeof(IContactsLogic), nameof(IContactsLogic.AllianceContacts)), ESI.Endpoints.Contacts.AllianceContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.AllianceContactLabels)), ESI.Endpoints.Contacts.AllianceContactLabels },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.DeleteCharacterContacts)), ESI.Endpoints.Contacts.DeleteCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.CharacterContacts)), ESI.Endpoints.Contacts.CharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.AddCharacterContacts)), ESI.Endpoints.Contacts.AddCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.UpdateCharacterContacts)), ESI.Endpoints.Contacts.UpdateCharacterContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.CharacterContactLabels)), ESI.Endpoints.Contacts.CharacterContactLabels },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.CorporationContacts)), ESI.Endpoints.Contacts.CorporationContacts },
                { Key(typeof(IContactsLogic), nameof(IContactsLogic.CorporationContactLabels)), ESI.Endpoints.Contacts.CorporationContactLabels },

                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CharacterContracts)), ESI.Endpoints.Contracts.CharacterContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CharacterContractBids)), ESI.Endpoints.Contracts.CharacterContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CharacterContractItems)), ESI.Endpoints.Contracts.CharacterContractItems },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.PublicContracts)), ESI.Endpoints.Contracts.PublicContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.PublicContractBids)), ESI.Endpoints.Contracts.PublicContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.PublicContractItems)), ESI.Endpoints.Contracts.PublicContractItems },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CorporationContracts)), ESI.Endpoints.Contracts.CorporationContracts },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CorporationContractBids)), ESI.Endpoints.Contracts.CorporationContractBids },
                { Key(typeof(IContractsLogic), nameof(IContractsLogic.CorporationContractItems)), ESI.Endpoints.Contracts.CorporationContractItems },

                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Information)), ESI.Endpoints.Corporation.Information },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.AllianceHistory)), ESI.Endpoints.Corporation.AllianceHistory },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Blueprints)), ESI.Endpoints.Corporation.Blueprints },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.ContainersLogs)), ESI.Endpoints.Corporation.ContainersLogs },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Divisions)), ESI.Endpoints.Corporation.Divisions },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Facilities)), ESI.Endpoints.Corporation.Facilities },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Icons)), ESI.Endpoints.Corporation.Icons },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Medals)), ESI.Endpoints.Corporation.Medals },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.IssuedMedals)), ESI.Endpoints.Corporation.IssuedMedals },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Members)), ESI.Endpoints.Corporation.Members },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.MembersLimit)), ESI.Endpoints.Corporation.MembersLimit },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.MembersTitles)), ESI.Endpoints.Corporation.MembersTitles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.MemberTracking)), ESI.Endpoints.Corporation.MemberTracking },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Roles)), ESI.Endpoints.Corporation.Roles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.RolesHistory)), ESI.Endpoints.Corporation.RolesHistory },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Shareholders)), ESI.Endpoints.Corporation.Shareholders },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Standings)), ESI.Endpoints.Corporation.Standings },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Starbases)), ESI.Endpoints.Corporation.Starbases },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.StarbaseInfo)), ESI.Endpoints.Corporation.StarbaseInfo },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Structures)), ESI.Endpoints.Corporation.Structures },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.Titles)), ESI.Endpoints.Corporation.Titles },
                { Key(typeof(ICorporationLogic), nameof(ICorporationLogic.NpcCorporations)), ESI.Endpoints.Corporation.NpcCorporations },

                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.Attributes)), ESI.Endpoints.Dogma.Attributes },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.AttributeInfo)), ESI.Endpoints.Dogma.AttributeInfo },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.DynamicItemInfo)), ESI.Endpoints.Dogma.DynamicItemInfo },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.Effects)), ESI.Endpoints.Dogma.Effects },
                { Key(typeof(IDogmaLogic), nameof(IDogmaLogic.EffectInfo)), ESI.Endpoints.Dogma.EffectInfo },

                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CharacterStats)), ESI.Endpoints.FactionWarfare.CharacterStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CorporationStats)), ESI.Endpoints.FactionWarfare.CorporationStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.FactionsLeaderboard)), ESI.Endpoints.FactionWarfare.FactionsLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CorporationsLeaderboard)), ESI.Endpoints.FactionWarfare.CorporationsLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CaractersLeaderboard)), ESI.Endpoints.FactionWarfare.CaractersLeaderboard},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.FactionsStats)), ESI.Endpoints.FactionWarfare.FactionsStats},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.OwnershipSystemOverview)), ESI.Endpoints.FactionWarfare.OwnershipSystemOverview},
                { Key(typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.Wars)), ESI.Endpoints.FactionWarfare.Wars},

                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.GetFittings)), ESI.Endpoints.Fittings.GetFittings },
                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.NewFitting)), ESI.Endpoints.Fittings.NewFitting },
                { Key(typeof(IFittingsLogic), nameof(IFittingsLogic.DeleteFitting)), ESI.Endpoints.Fittings.DeleteFitting },

                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.FleetInfo)), ESI.Endpoints.Fleets.FleetInfo },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.FleetSettings)), ESI.Endpoints.Fleets.FleetSettings },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.FleetMembers)), ESI.Endpoints.Fleets.FleetMembers },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.FleetWings)), ESI.Endpoints.Fleets.FleetWings },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.NewWing)), ESI.Endpoints.Fleets.NewWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.NewSquad)), ESI.Endpoints.Fleets.NewSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteWing)), ESI.Endpoints.Fleets.DeleteWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteSquad)), ESI.Endpoints.Fleets.DeleteSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.RenameWing)), ESI.Endpoints.Fleets.RenameWing },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.RenameSquad)), ESI.Endpoints.Fleets.RenameSquad },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.UpdateFleetSettings)), ESI.Endpoints.Fleets.UpdateFleetSettings },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.MoveMember)), ESI.Endpoints.Fleets.MoveMember },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.KickMember)), ESI.Endpoints.Fleets.KickMember },
                { Key(typeof(IFleetsLogic), nameof(IFleetsLogic.InviteMember)), ESI.Endpoints.Fleets.InviteMember },

                { Key(typeof(IIncursionsLogic), nameof(IIncursionsLogic.IncursionList)), ESI.Endpoints.Incursions.IncursionList },

                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.CharacterJobs)), ESI.Endpoints.Industry.CharacterJobs },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.CharacterMiningLedger)), ESI.Endpoints.Industry.CharacterMiningLedger },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.ExtractionTimers)), ESI.Endpoints.Industry.ExtractionTimers },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.CorporationJobs)), ESI.Endpoints.Industry.CorporationJobs },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.ObserverInfo)), ESI.Endpoints.Industry.ObserverInfo },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.CorporationObservers)), ESI.Endpoints.Industry.CorporationObservers },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.Facilities)), ESI.Endpoints.Industry.Facilities },
                { Key(typeof(IIndustryLogic), nameof(IIndustryLogic.SolarSystems)), ESI.Endpoints.Industry.SolarSystems },

                { Key(typeof(IInsuranceLogic), nameof(IInsuranceLogic.InsuranceLevels)), ESI.Endpoints.Insurence.InsuranceLevels },

                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.CharacterKillmails)), ESI.Endpoints.Killmails.CharacterKillmails },
                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.CorporationKillmails)), ESI.Endpoints.Killmails.CorporationKillmails },
                { Key(typeof(IKillmailsLogic), nameof(IKillmailsLogic.KillmailInfo)), ESI.Endpoints.Killmails.KillmailInfo },

                { Key(typeof(ILocationLogic), nameof(ILocationLogic.CurrentLocation)), ESI.Endpoints.Location.CurrentLocation },
                { Key(typeof(ILocationLogic), nameof(ILocationLogic.Online)), ESI.Endpoints.Location.Online },
                { Key(typeof(ILocationLogic), nameof(ILocationLogic.CurrentShip)), ESI.Endpoints.Location.CurrentShip },

                { Key(typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.LoyaltyPoints)), ESI.Endpoints.Loyalty.LoyaltyPoints },
                { Key(typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.CorporationOffers)), ESI.Endpoints.Loyalty.CorporationOffers },

                { Key(typeof(IMailLogic), nameof(IMailLogic.MailHeaders)), ESI.Endpoints.Mail.MailHeaders },
                { Key(typeof(IMailLogic), nameof(IMailLogic.SendMail)), ESI.Endpoints.Mail.SendMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.GetMail)), ESI.Endpoints.Mail.GetMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.UpdateMail)), ESI.Endpoints.Mail.UpdateMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.DeleteMail)), ESI.Endpoints.Mail.DeleteMail },
                { Key(typeof(IMailLogic), nameof(IMailLogic.GetLabels)), ESI.Endpoints.Mail.GetLabels },
                { Key(typeof(IMailLogic), nameof(IMailLogic.NewMailLabel)), ESI.Endpoints.Mail.CreateLabel },
                { Key(typeof(IMailLogic), nameof(IMailLogic.DeleteLabel)), ESI.Endpoints.Mail.DeleteLabel },
                { Key(typeof(IMailLogic), nameof(IMailLogic.MailingList)), ESI.Endpoints.Mail.MailingList },

                { Key(typeof(IMarketLogic), nameof(IMarketLogic.CharacterOrders)), ESI.Endpoints.Market.CharacterOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.CharacterOrdersHistory)), ESI.Endpoints.Market.CharacterOrdersHistory },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.CorporationOrders)), ESI.Endpoints.Market.CorporationOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.CorporationOrdersHistory)), ESI.Endpoints.Market.CorporationOrdersHistory },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.RegionOrders)), ESI.Endpoints.Market.RegionOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.RegionStatistics)), ESI.Endpoints.Market.RegionStatistics },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.StructureOrders)), ESI.Endpoints.Market.StructureOrders },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.MarketGroups)), ESI.Endpoints.Market.MarketGroups },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.MarketGroupInfo)), ESI.Endpoints.Market.MarketGroupInfo },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.TypePrices)), ESI.Endpoints.Market.TypePrices },
                { Key(typeof(IMarketLogic), nameof(IMarketLogic.ActiveRegionOrderTypes)), ESI.Endpoints.Market.ActiveRegionOrderTypes },

                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.CompletedTasks)), ESI.Endpoints.Opportunities.CompletedTasks },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.Groups)), ESI.Endpoints.Opportunities.Groups },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GroupInfo)), ESI.Endpoints.Opportunities.GroupInfo },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.Tasks)), ESI.Endpoints.Opportunities.Tasks },
                { Key(typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.TaskInfo)), ESI.Endpoints.Opportunities.TaskInfo },

                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.Colonies)), ESI.Endpoints.PlanetaryInteraction.Colonies },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.ColonyInfo)), ESI.Endpoints.PlanetaryInteraction.ColonyInfo },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.CorporationCustomOffices)), ESI.Endpoints.PlanetaryInteraction.CustomOffices },
                { Key(typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.SchematicInfo)), ESI.Endpoints.PlanetaryInteraction.SchematicInfo },

                { Key(typeof(IRoutesLogic), nameof(IRoutesLogic.Route)), ESI.Endpoints.Routes.Route },

                { Key(typeof(ISearchLogic), nameof(ISearchLogic.Query)), ESI.Endpoints.Search.Query },

                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.Attributes)), ESI.Endpoints.Skills.Attributes },
                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.SkillQueue)), ESI.Endpoints.Skills.SkillQueue },
                { Key(typeof(ISkillsLogic), nameof(ISkillsLogic.SkillDetails)), ESI.Endpoints.Skills.SkillDetails },

                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Campaigns)), ESI.Endpoints.Sovereignty.Campaigns },
                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.SolarSystems)), ESI.Endpoints.Sovereignty.SolarSystems },
                { Key(typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Structures)), ESI.Endpoints.Sovereignty.Structures },

                { Key(typeof(IStatusLogic), nameof(IStatusLogic.ServerStatus)), ESI.Endpoints.Status.ServerStatus },

                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Ancestries)), ESI.Endpoints.Universe.Ancestries },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Races)), ESI.Endpoints.Universe.Races },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Constellations)), ESI.Endpoints.Universe.Constellations },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.AsteroidBeltInfo)), ESI.Endpoints.Universe.AsteroidBeltInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Bloodlines)), ESI.Endpoints.Universe.Bloodlines },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.ConstellationInfo)), ESI.Endpoints.Universe.ConstellationInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Factions)), ESI.Endpoints.Universe.Factions },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Graphics)), ESI.Endpoints.Universe.Graphics },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.GraphicInfo)), ESI.Endpoints.Universe.GraphicInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.IDs)), ESI.Endpoints.Universe.IDs },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.ItemCategories)), ESI.Endpoints.Universe.ItemCategories },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.ItemCategoryInfo)), ESI.Endpoints.Universe.ItemCategoryInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.ItemGroups)), ESI.Endpoints.Universe.ItemGroups },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.ItemGroupInfo)), ESI.Endpoints.Universe.ItemGroupInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.MoonInfo)), ESI.Endpoints.Universe.MoonInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Names)), ESI.Endpoints.Universe.Names },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.PlanetInfo)), ESI.Endpoints.Universe.PlanetInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.RegionInfo)), ESI.Endpoints.Universe.RegionInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Types)), ESI.Endpoints.Universe.Types },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.TypeInfo)), ESI.Endpoints.Universe.TypeInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.SystemKills)), ESI.Endpoints.Universe.SystemKills },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.SystemJumps)), ESI.Endpoints.Universe.SystemJumps },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Structures)), ESI.Endpoints.Universe.Structures },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.StructureInfo)), ESI.Endpoints.Universe.StructureInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.StationInfo)), ESI.Endpoints.Universe.StationInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.StarInfo)), ESI.Endpoints.Universe.StarInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.StargateInfo)), ESI.Endpoints.Universe.StargateInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.Regions)), ESI.Endpoints.Universe.Regions },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.SolarSystemInfo)), ESI.Endpoints.Universe.SolarSystemInfo },
                { Key(typeof(IUniverseLogic), nameof(IUniverseLogic.SolarSystems)), ESI.Endpoints.Universe.SolarSystems },

                { Key(typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenContractWindow)), ESI.Endpoints.UserInterface.OpenContractWindow },
                { Key(typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenInformationWindow)), ESI.Endpoints.UserInterface.OpenInformationWindow },
                { Key(typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenMarketDetails)), ESI.Endpoints.UserInterface.OpenMarketDetails },
                { Key(typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.SetAutopilotWaypoint)), ESI.Endpoints.UserInterface.SetAutopilotWaypoint },
                { Key(typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenNewMailWindow)), ESI.Endpoints.UserInterface.OpenNewMailWindow },

                { Key(typeof(IWalletLogic), nameof(IWalletLogic.WalletBalance)), ESI.Endpoints.Wallet.WalletBalance },
                { Key(typeof(IWalletLogic), nameof(IWalletLogic.WalletTransactions)), ESI.Endpoints.Wallet.WalletTransactions },
                { Key(typeof(IWalletLogic), nameof(IWalletLogic.WalletJournal)), ESI.Endpoints.Wallet.WalletJournal },
                { Key(typeof(IWalletLogic), nameof(IWalletLogic.CorporationWalletJournal)), ESI.Endpoints.Wallet.CorporationWalletJournal },
                { Key(typeof(IWalletLogic), nameof(IWalletLogic.CorporationWallets)), ESI.Endpoints.Wallet.CorporationWallets },
                { Key(typeof(IWalletLogic), nameof(IWalletLogic.CorporationWalletTransactions)), ESI.Endpoints.Wallet.CorporationWalletTransactions },

                { Key(typeof(IWarsLogic), nameof(IWarsLogic.Kills)), ESI.Endpoints.Wars.Kills },
                { Key(typeof(IWarsLogic), nameof(IWarsLogic.Wars)), ESI.Endpoints.Wars.WarList },
                { Key(typeof(IWarsLogic), nameof(IWarsLogic.WarDetails)), ESI.Endpoints.Wars.WarDetails }
            };
        }

        public static string ToEndpointId(Type callingMemberType, string callerMember) => _dataset[Key(callingMemberType, callerMember)];

        private static string Key(Type callingMemberType, string callerMember) => $"{callingMemberType.Name}-{callerMember}";
    }
}
