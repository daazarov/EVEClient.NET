using System;
using System.Net.Http;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;

namespace EVEClient.NET.Utilities
{
    internal class EndpointsMapper : IEnumerable<KeyValuePair<EndpointMarker, string>>
    {
        private readonly ImmutableDictionary<EndpointMarker, string> _dataset;
        private readonly ImmutableDictionary<string, EndpointMarker> _datasetReverse;

        private static readonly Lazy<EndpointsMapper> _singletone = new(() => new());

        public static EndpointsMapper Instance => _singletone.Value;

        public string? this[EndpointMarker key]
        {
            get
            {
                if (_dataset.TryGetValue(key, out var value))
                {
                    return value;
                }
                return null;
            }
        }
        public EndpointMarker this[string key]
        {
            get
            {
                if (_datasetReverse.TryGetValue(key, out var value))
                {
                    return value;
                }
                return EndpointMarker.Null;
            }
        }

        private EndpointsMapper()
        {
            _dataset = ImmutableDictionary.CreateRange(new Dictionary<EndpointMarker, string>
            {
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.PublicInformation)), ESI.Endpoints.Characters.PublicInformation },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Standings)), ESI.Endpoints.Characters.Standings },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.AgentsResearch)), ESI.Endpoints.Characters.AgentsResearch },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Blueprints)), ESI.Endpoints.Characters.Blueprints },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.CorporationHistory)), ESI.Endpoints.Characters.CorporationHistory },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.CSPA)), ESI.Endpoints.Characters.CSPA },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Fatigue)), ESI.Endpoints.Characters.Fatigue },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Medals)),  ESI.Endpoints.Characters.Medals },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Notifications)), ESI.Endpoints.Characters.Notifications },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.ContactNotifications)), ESI.Endpoints.Characters.ContactNotifications },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Portrait)),  ESI.Endpoints.Characters.Portrait },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Roles)), ESI.Endpoints.Characters.Roles },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Titles)),  ESI.Endpoints.Characters.Titles },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(ICharacterLogic), nameof(ICharacterLogic.Affilation)), ESI.Endpoints.Characters.Affilation },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAllianceLogic), nameof(IAllianceLogic.ActiveAlliances)), ESI.Endpoints.Alliances.ActiveAlliances },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAllianceLogic), nameof(IAllianceLogic.PublicInformation)), ESI.Endpoints.Alliances.PublicInformation },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAllianceLogic), nameof(IAllianceLogic.CorporationsInAlliance)), ESI.Endpoints.Alliances.CorporationsInAlliance },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAllianceLogic), nameof(IAllianceLogic.AllianceIcon)), ESI.Endpoints.Alliances.AllianceIcon },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.CharacterAssetList)), ESI.Endpoints.Assets.CharacterAssetList },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.LocationAssets)), ESI.Endpoints.Assets.LocationAssets },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.AssetItemNames)), ESI.Endpoints.Assets.AssetItemNames },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationAssetList)), ESI.Endpoints.Assets.CorporationAssetList },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationLocationAssets)), ESI.Endpoints.Assets.CorporationLocationAssets },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IAssetsLogic), nameof(IAssetsLogic.CorporationAssetItemNames)), ESI.Endpoints.Assets.CorporationAssetItemNames },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IBookmarksLogic), nameof(IBookmarksLogic.CharacterBookmarks)), ESI.Endpoints.Bookmarks.CharacterBookmarks },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IBookmarksLogic), nameof(IBookmarksLogic.CharacterBookmarkFolders)), ESI.Endpoints.Bookmarks.CharacterBookmarkFolders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IBookmarksLogic), nameof(IBookmarksLogic.CorporationBookmarks)), ESI.Endpoints.Bookmarks.CorporationBookmarks },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IBookmarksLogic), nameof(IBookmarksLogic.CorporationBookmarkFolders)), ESI.Endpoints.Bookmarks.CorporationBookmarkFolders },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICalendarLogic), nameof(ICalendarLogic.CalendarItems)), ESI.Endpoints.Calendar.CalendarItems },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICalendarLogic), nameof(ICalendarLogic.CalendarEvent)), ESI.Endpoints.Calendar.CalendarEvent },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(ICalendarLogic), nameof(ICalendarLogic.RespondeEvent)), ESI.Endpoints.Calendar.RespondeEvent },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICalendarLogic), nameof(ICalendarLogic.EventAttendees)), ESI.Endpoints.Calendar.EventAttendees },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IClonesLogic), nameof(IClonesLogic.CloneList)), ESI.Endpoints.Clones.CloneList },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IClonesLogic), nameof(IClonesLogic.CloneImplants)), ESI.Endpoints.Clones.CloneImplants },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.AllianceContacts)), ESI.Endpoints.Contacts.AllianceContacts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.AllianceContactLabels)), ESI.Endpoints.Contacts.AllianceContactLabels },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IContactsLogic), nameof(IContactsLogic.DeleteCharacterContacts)), ESI.Endpoints.Contacts.DeleteCharacterContacts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.CharacterContacts)), ESI.Endpoints.Contacts.CharacterContacts },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IContactsLogic), nameof(IContactsLogic.AddCharacterContacts)), ESI.Endpoints.Contacts.AddCharacterContacts },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IContactsLogic), nameof(IContactsLogic.UpdateCharacterContacts)), ESI.Endpoints.Contacts.UpdateCharacterContacts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.CharacterContactLabels)), ESI.Endpoints.Contacts.CharacterContactLabels },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.CorporationContacts)), ESI.Endpoints.Contacts.CorporationContacts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContactsLogic), nameof(IContactsLogic.CorporationContactLabels)), ESI.Endpoints.Contacts.CorporationContactLabels },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CharacterContracts)), ESI.Endpoints.Contracts.CharacterContracts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CharacterContractBids)), ESI.Endpoints.Contracts.CharacterContractBids },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CharacterContractItems)), ESI.Endpoints.Contracts.CharacterContractItems },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.PublicContracts)), ESI.Endpoints.Contracts.PublicContracts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.PublicContractBids)), ESI.Endpoints.Contracts.PublicContractBids },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.PublicContractItems)), ESI.Endpoints.Contracts.PublicContractItems },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CorporationContracts)), ESI.Endpoints.Contracts.CorporationContracts },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CorporationContractBids)), ESI.Endpoints.Contracts.CorporationContractBids },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IContractsLogic), nameof(IContractsLogic.CorporationContractItems)), ESI.Endpoints.Contracts.CorporationContractItems },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Information)), ESI.Endpoints.Corporation.Information },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.AllianceHistory)), ESI.Endpoints.Corporation.AllianceHistory },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Blueprints)), ESI.Endpoints.Corporation.Blueprints },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.ContainersLogs)), ESI.Endpoints.Corporation.ContainersLogs },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Divisions)), ESI.Endpoints.Corporation.Divisions },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Facilities)), ESI.Endpoints.Corporation.Facilities },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Icons)), ESI.Endpoints.Corporation.Icons },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Medals)), ESI.Endpoints.Corporation.Medals },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.IssuedMedals)), ESI.Endpoints.Corporation.IssuedMedals },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Members)), ESI.Endpoints.Corporation.Members },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.MembersLimit)), ESI.Endpoints.Corporation.MembersLimit },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.MembersTitles)), ESI.Endpoints.Corporation.MembersTitles },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.MemberTracking)), ESI.Endpoints.Corporation.MemberTracking },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Roles)), ESI.Endpoints.Corporation.Roles },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.RolesHistory)), ESI.Endpoints.Corporation.RolesHistory },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Shareholders)), ESI.Endpoints.Corporation.Shareholders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Standings)), ESI.Endpoints.Corporation.Standings },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Starbases)), ESI.Endpoints.Corporation.Starbases },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.StarbaseInfo)), ESI.Endpoints.Corporation.StarbaseInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Structures)), ESI.Endpoints.Corporation.Structures },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.Titles)), ESI.Endpoints.Corporation.Titles },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ICorporationLogic), nameof(ICorporationLogic.NpcCorporations)), ESI.Endpoints.Corporation.NpcCorporations },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IDogmaLogic), nameof(IDogmaLogic.Attributes)), ESI.Endpoints.Dogma.Attributes },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IDogmaLogic), nameof(IDogmaLogic.AttributeInfo)), ESI.Endpoints.Dogma.AttributeInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IDogmaLogic), nameof(IDogmaLogic.DynamicItemInfo)), ESI.Endpoints.Dogma.DynamicItemInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IDogmaLogic), nameof(IDogmaLogic.Effects)), ESI.Endpoints.Dogma.Effects },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IDogmaLogic), nameof(IDogmaLogic.EffectInfo)), ESI.Endpoints.Dogma.EffectInfo },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CharacterStats)), ESI.Endpoints.FactionWarfare.CharacterStats},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CorporationStats)), ESI.Endpoints.FactionWarfare.CorporationStats},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.FactionsLeaderboard)), ESI.Endpoints.FactionWarfare.FactionsLeaderboard},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CorporationsLeaderboard)), ESI.Endpoints.FactionWarfare.CorporationsLeaderboard},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.CaractersLeaderboard)), ESI.Endpoints.FactionWarfare.CaractersLeaderboard},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.FactionsStats)), ESI.Endpoints.FactionWarfare.FactionsStats},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.OwnershipSystemOverview)), ESI.Endpoints.FactionWarfare.OwnershipSystemOverview},
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFactionWarfareLogic), nameof(IFactionWarfareLogic.Wars)), ESI.Endpoints.FactionWarfare.Wars},

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFittingsLogic), nameof(IFittingsLogic.GetFittings)), ESI.Endpoints.Fittings.GetFittings },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IFittingsLogic), nameof(IFittingsLogic.NewFitting)), ESI.Endpoints.Fittings.NewFitting },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IFittingsLogic), nameof(IFittingsLogic.DeleteFitting)), ESI.Endpoints.Fittings.DeleteFitting },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.FleetInfo)), ESI.Endpoints.Fleets.FleetInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.FleetSettings)), ESI.Endpoints.Fleets.FleetSettings },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.FleetMembers)), ESI.Endpoints.Fleets.FleetMembers },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.FleetWings)), ESI.Endpoints.Fleets.FleetWings },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.NewWing)), ESI.Endpoints.Fleets.NewWing },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.NewSquad)), ESI.Endpoints.Fleets.NewSquad },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteWing)), ESI.Endpoints.Fleets.DeleteWing },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.DeleteSquad)), ESI.Endpoints.Fleets.DeleteSquad },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.RenameWing)), ESI.Endpoints.Fleets.RenameWing },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.RenameSquad)), ESI.Endpoints.Fleets.RenameSquad },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.UpdateFleetSettings)), ESI.Endpoints.Fleets.UpdateFleetSettings },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.MoveMember)), ESI.Endpoints.Fleets.MoveMember },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.KickMember)), ESI.Endpoints.Fleets.KickMember },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IFleetsLogic), nameof(IFleetsLogic.InviteMember)), ESI.Endpoints.Fleets.InviteMember },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIncursionsLogic), nameof(IIncursionsLogic.IncursionList)), ESI.Endpoints.Incursions.IncursionList },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.CharacterJobs)), ESI.Endpoints.Industry.CharacterJobs },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.CharacterMiningLedger)), ESI.Endpoints.Industry.CharacterMiningLedger },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.ExtractionTimers)), ESI.Endpoints.Industry.ExtractionTimers },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.CorporationJobs)), ESI.Endpoints.Industry.CorporationJobs },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.ObserverInfo)), ESI.Endpoints.Industry.ObserverInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.CorporationObservers)), ESI.Endpoints.Industry.CorporationObservers },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.Facilities)), ESI.Endpoints.Industry.Facilities },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IIndustryLogic), nameof(IIndustryLogic.SolarSystems)), ESI.Endpoints.Industry.SolarSystems },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IInsuranceLogic), nameof(IInsuranceLogic.InsuranceLevels)), ESI.Endpoints.Insurence.InsuranceLevels },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IKillmailsLogic), nameof(IKillmailsLogic.CharacterKillmails)), ESI.Endpoints.Killmails.CharacterKillmails },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IKillmailsLogic), nameof(IKillmailsLogic.CorporationKillmails)), ESI.Endpoints.Killmails.CorporationKillmails },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IKillmailsLogic), nameof(IKillmailsLogic.KillmailInfo)), ESI.Endpoints.Killmails.KillmailInfo },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ILocationLogic), nameof(ILocationLogic.CurrentLocation)), ESI.Endpoints.Location.CurrentLocation },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ILocationLogic), nameof(ILocationLogic.Online)), ESI.Endpoints.Location.Online },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ILocationLogic), nameof(ILocationLogic.CurrentShip)), ESI.Endpoints.Location.CurrentShip },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.LoyaltyPoints)), ESI.Endpoints.Loyalty.LoyaltyPoints },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ILoyaltyLogic), nameof(ILoyaltyLogic.CorporationOffers)), ESI.Endpoints.Loyalty.CorporationOffers },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMailLogic), nameof(IMailLogic.MailHeaders)), ESI.Endpoints.Mail.MailHeaders },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IMailLogic), nameof(IMailLogic.SendMail)), ESI.Endpoints.Mail.SendMail },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMailLogic), nameof(IMailLogic.GetMail)), ESI.Endpoints.Mail.GetMail },
                { new EndpointMarker(HttpMethod.Put.Method, typeof(IMailLogic), nameof(IMailLogic.UpdateMail)), ESI.Endpoints.Mail.UpdateMail },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IMailLogic), nameof(IMailLogic.DeleteMail)), ESI.Endpoints.Mail.DeleteMail },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMailLogic), nameof(IMailLogic.GetLabels)), ESI.Endpoints.Mail.GetLabels },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IMailLogic), nameof(IMailLogic.NewMailLabel)), ESI.Endpoints.Mail.CreateLabel },
                { new EndpointMarker(HttpMethod.Delete.Method, typeof(IMailLogic), nameof(IMailLogic.DeleteLabel)), ESI.Endpoints.Mail.DeleteLabel },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMailLogic), nameof(IMailLogic.MailingList)), ESI.Endpoints.Mail.MailingList },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.CharacterOrders)), ESI.Endpoints.Market.CharacterOrders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.CharacterOrdersHistory)), ESI.Endpoints.Market.CharacterOrdersHistory },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.CorporationOrders)), ESI.Endpoints.Market.CorporationOrders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.CorporationOrdersHistory)), ESI.Endpoints.Market.CorporationOrdersHistory },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.RegionOrders)), ESI.Endpoints.Market.RegionOrders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.RegionStatistics)), ESI.Endpoints.Market.RegionStatistics },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.StructureOrders)), ESI.Endpoints.Market.StructureOrders },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.MarketGroups)), ESI.Endpoints.Market.MarketGroups },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.MarketGroupInfo)), ESI.Endpoints.Market.MarketGroupInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.TypePrices)), ESI.Endpoints.Market.TypePrices },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IMarketLogic), nameof(IMarketLogic.ActiveRegionOrderTypes)), ESI.Endpoints.Market.ActiveRegionOrderTypes },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.CompletedTasks)), ESI.Endpoints.Opportunities.CompletedTasks },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.Groups)), ESI.Endpoints.Opportunities.Groups },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.GroupInfo)), ESI.Endpoints.Opportunities.GroupInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.Tasks)), ESI.Endpoints.Opportunities.Tasks },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IOpportunitiesLogic), nameof(IOpportunitiesLogic.TaskInfo)), ESI.Endpoints.Opportunities.TaskInfo },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.Colonies)), ESI.Endpoints.PlanetaryInteraction.Colonies },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.ColonyInfo)), ESI.Endpoints.PlanetaryInteraction.ColonyInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.CorporationCustomOffices)), ESI.Endpoints.PlanetaryInteraction.CustomOffices },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IPlanetaryInteractionLogic), nameof(IPlanetaryInteractionLogic.SchematicInfo)), ESI.Endpoints.PlanetaryInteraction.SchematicInfo },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IRoutesLogic), nameof(IRoutesLogic.Route)), ESI.Endpoints.Routes.Route },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISearchLogic), nameof(ISearchLogic.Query)), ESI.Endpoints.Search.Query },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISkillsLogic), nameof(ISkillsLogic.Attributes)), ESI.Endpoints.Skills.Attributes },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISkillsLogic), nameof(ISkillsLogic.SkillQueue)), ESI.Endpoints.Skills.SkillQueue },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISkillsLogic), nameof(ISkillsLogic.SkillDetails)), ESI.Endpoints.Skills.SkillDetails },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Campaigns)), ESI.Endpoints.Sovereignty.Campaigns },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.SolarSystems)), ESI.Endpoints.Sovereignty.SolarSystems },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(ISovereigntyLogic), nameof(ISovereigntyLogic.Structures)), ESI.Endpoints.Sovereignty.Structures },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IStatusLogic), nameof(IStatusLogic.ServerStatus)), ESI.Endpoints.Status.ServerStatus },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Ancestries)), ESI.Endpoints.Universe.Ancestries },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Races)), ESI.Endpoints.Universe.Races },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Constellations)), ESI.Endpoints.Universe.Constellations },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.AsteroidBeltInfo)), ESI.Endpoints.Universe.AsteroidBeltInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Bloodlines)), ESI.Endpoints.Universe.Bloodlines },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.ConstellationInfo)), ESI.Endpoints.Universe.ConstellationInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Factions)), ESI.Endpoints.Universe.Factions },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Graphics)), ESI.Endpoints.Universe.Graphics },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.GraphicInfo)), ESI.Endpoints.Universe.GraphicInfo },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.IDs)), ESI.Endpoints.Universe.IDs },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.ItemCategories)), ESI.Endpoints.Universe.ItemCategories },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.ItemCategoryInfo)), ESI.Endpoints.Universe.ItemCategoryInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.ItemGroups)), ESI.Endpoints.Universe.ItemGroups },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.ItemGroupInfo)), ESI.Endpoints.Universe.ItemGroupInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.MoonInfo)), ESI.Endpoints.Universe.MoonInfo },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Names)), ESI.Endpoints.Universe.Names },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.PlanetInfo)), ESI.Endpoints.Universe.PlanetInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.RegionInfo)), ESI.Endpoints.Universe.RegionInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Types)), ESI.Endpoints.Universe.Types },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.TypeInfo)), ESI.Endpoints.Universe.TypeInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.SystemKills)), ESI.Endpoints.Universe.SystemKills },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.SystemJumps)), ESI.Endpoints.Universe.SystemJumps },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Structures)), ESI.Endpoints.Universe.Structures },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.StructureInfo)), ESI.Endpoints.Universe.StructureInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.StationInfo)), ESI.Endpoints.Universe.StationInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.StarInfo)), ESI.Endpoints.Universe.StarInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.StargateInfo)), ESI.Endpoints.Universe.StargateInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.Regions)), ESI.Endpoints.Universe.Regions },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.SolarSystemInfo)), ESI.Endpoints.Universe.SolarSystemInfo },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IUniverseLogic), nameof(IUniverseLogic.SolarSystems)), ESI.Endpoints.Universe.SolarSystems },

                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenContractWindow)), ESI.Endpoints.UserInterface.OpenContractWindow },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenInformationWindow)), ESI.Endpoints.UserInterface.OpenInformationWindow },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenMarketDetails)), ESI.Endpoints.UserInterface.OpenMarketDetails },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.SetAutopilotWaypoint)), ESI.Endpoints.UserInterface.SetAutopilotWaypoint },
                { new EndpointMarker(HttpMethod.Post.Method, typeof(IUserInterfaceLogic), nameof(IUserInterfaceLogic.OpenNewMailWindow)), ESI.Endpoints.UserInterface.OpenNewMailWindow },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.WalletBalance)), ESI.Endpoints.Wallet.WalletBalance },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.WalletTransactions)), ESI.Endpoints.Wallet.WalletTransactions },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.WalletJournal)), ESI.Endpoints.Wallet.WalletJournal },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.CorporationWalletJournal)), ESI.Endpoints.Wallet.CorporationWalletJournal },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.CorporationWallets)), ESI.Endpoints.Wallet.CorporationWallets },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWalletLogic), nameof(IWalletLogic.CorporationWalletTransactions)), ESI.Endpoints.Wallet.CorporationWalletTransactions },

                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWarsLogic), nameof(IWarsLogic.Kills)), ESI.Endpoints.Wars.Kills },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWarsLogic), nameof(IWarsLogic.Wars)), ESI.Endpoints.Wars.WarList },
                { new EndpointMarker(HttpMethod.Get.Method, typeof(IWarsLogic), nameof(IWarsLogic.WarDetails)), ESI.Endpoints.Wars.WarDetails }
            });

            _datasetReverse = ImmutableDictionary.CreateRange(_dataset.Select(x => new KeyValuePair<string, EndpointMarker>(x.Value, x.Key)));
        }

        public IEnumerator<KeyValuePair<EndpointMarker, string>> GetEnumerator()
        {
            return _dataset.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
