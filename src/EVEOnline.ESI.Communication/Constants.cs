using System.Collections.Generic;
using System.Collections.Immutable;

namespace EVEOnline.ESI.Communication
{
    public class ESI
    {
        internal const string HttpClientName = "EsiHttpClient";
        
        internal static class EsiClientMethodNames
        {
            public const string GetRequest = "GetRequest";
            public const string GetRequestWithouRequestParameters = "GetRequestWithouRequestParameters";
            public const string GetPaginationRequest = "GetPaginationRequest";
            public const string GetPaginationRequestWithouRequestParameters = "GetPaginationRequestWithouRequestParameters";
            public const string PostRequest = "PostRequest";
            public const string PostNoContentRequest = "PostNoContentRequest";
            public const string PutRequest = "PutRequest";
            public const string DeleteRequest = "DeleteRequest";
        }

        public static ImmutableDictionary<string, EndpointVersion> AvailableRoutes => ImmutableDictionary.CreateRange(new Dictionary<string, EndpointVersion>
        {
            { Endpoints.Characters.PublicInformation, EndpointVersion.V5 | EndpointVersion.Latest | EndpointVersion.Legacy | EndpointVersion.Dev },
            { Endpoints.Characters.Standings, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.AgentsResearch, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.Blueprints, EndpointVersion.Latest | EndpointVersion.V3 | EndpointVersion.Dev },
            { Endpoints.Characters.CorporationHistory, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.CSPA, EndpointVersion.Latest | EndpointVersion.V5 | EndpointVersion.Dev },
            { Endpoints.Characters.Fatigue, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.Medals, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.Notifications, EndpointVersion.Latest | EndpointVersion.V5 | EndpointVersion.V6 | EndpointVersion.Dev },
            { Endpoints.Characters.ContactNotifications, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.Portrait, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.V3 | EndpointVersion.Dev },
            { Endpoints.Characters.Roles, EndpointVersion.Latest | EndpointVersion.V3 | EndpointVersion.Dev },
            { Endpoints.Characters.Titles, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev },
            { Endpoints.Characters.Affilation, EndpointVersion.Latest | EndpointVersion.V2 | EndpointVersion.Dev }
        });

        public static class Endpoints
        {
            public static class Characters
            {
                public const string PublicInformation =               "get_characters_character_id";
                public const string Standings =                       "get_characters_character_id_standings";
                public const string AgentsResearch =                  "get_characters_character_id_agents_research";
                public const string Blueprints =                      "get_characters_character_id_blueprints";
                public const string CorporationHistory =              "get_characters_character_id_corporationhistory";
                public const string CSPA =                            "post_characters_character_id_cspa";
                public const string Fatigue =                         "get_characters_character_id_fatigue";
                public const string Medals =                          "get_characters_character_id_medals";
                public const string Notifications =                   "get_characters_character_id_notifications";
                public const string ContactNotifications =            "get_characters_character_id_notifications_contacts";
                public const string Portrait =                        "get_characters_character_id_portrait";
                public const string Roles =                           "get_characters_character_id_roles";
                public const string Titles =                          "get_characters_character_id_titles";
                public const string Affilation =                      "post_characters_affiliation";
            }

            public static class Alliances
            {
                public const string AllianceList =                    "get_alliance";
                public const string PublicInformation =               "get_alliances_alliance_id";
                public const string CorporationsInAlliance =          "get_alliances_alliance_id_corporations";
                public const string AllianceIcon =                    "get_alliances_alliance_id_icons";
            }

            public static class Assets 
            {
                public const string CharacterAssetList =              "get_characters_character_id_assets";
                public const string LocationAssets =                  "post_characters_character_id_assets_locations";
                public const string AssetItemNames =                  "post_characters_character_id_assets_names";
                public const string CorporationAssetList =            "get_corporations_corporation_id_assets";
                public const string CorporationLocationAssets =       "post_corporations_corporation_id_assets_locations";
                public const string CorporationAssetItemNames =       "post_corporations_corporation_id_assets_names";
            }

            public static class Bookmarks 
            {
                public const string CharacterBookmarkList =           "get_characters_character_id_bookmarks";
                public const string CharacterBookmarkFolderList =     "get_characters_character_id_bookmarks_folders";
                public const string CorporationBookmarkList =         "get_corporations_corporation_id_bookmarks";
                public const string CorporationBookmarkFolderList =   "get_corporations_corporation_id_bookmarks_folders";
            }

            public static class Calendar
            {
                public const string CalendarItems =                   "get_characters_character_id_calendar";
                public const string CalendarEvent =                   "get_characters_character_id_calendar_event_id";
                public const string RespondeEvent =                   "put_characters_character_id_calendar_event_id";
                public const string EventAttendees =                  "get_characters_character_id_calendar_event_id_attendees";
            }

            public static class Clones
            {
                public const string CloneList =                       "get_characters_character_id_clones";
                public const string CloneImplants =                   "get_characters_character_id_implants";
            }

            public static class Contacts
            {
                public const string AllianceContactList =             "get_alliances_alliance_id_contacts";
                public const string AllianceContactLabelList =        "get_alliances_alliance_id_contacts_labels";
                public const string DeleteCharacterContacts =         "delete_characters_character_id_contacts";
                public const string CharacterContactList =            "get_characters_character_id_contacts";
                public const string AddCharacterContacts =            "post_characters_character_id_contacts";
                public const string UpdateCharacterContacts =         "put_characters_character_id_contacts";
                public const string CharacterContactLabelList =       "get_characters_character_id_contacts_labels";
                public const string CorporationContactList =          "get_corporations_corporation_id_contacts";
                public const string CorporationContactLabelList =     "get_corporations_corporation_id_contacts_labels";
            }

            public static class Contracts
            {
                public const string CharacterContracts =              "get_characters_character_id_contracts";
                public const string CharacterContractBids =           "get_characters_character_id_contracts_contract_id_bids";
                public const string CharacterContractItems =          "get_characters_character_id_contracts_contract_id_items";
                public const string PublicContracts =                 "get_contracts_public_region_id";
                public const string PublicContractBids =              "get_contracts_public_bids_contract_id";
                public const string PublicContractItems =             "get_contracts_public_items_contract_id";
                public const string CorporationContracts =            "get_corporations_corporation_id_contracts";
                public const string CorporationContractBids =         "get_corporations_corporation_id_contracts_contract_id_bids";
                public const string CorporationContractItems =        "get_corporations_corporation_id_contracts_contract_id_items";
            }

            public static class Corporation 
            {
                public const string Information =                     "get_corporations_corporation_id";
                public const string AllianceHistory =                 "get_corporations_corporation_id_alliancehistory";
                public const string Blueprints =                      "get_corporations_corporation_id_blueprints";
                public const string ContainersLogs =                  "get_corporations_corporation_id_containers_logs";
                public const string Divisions =                       "get_corporations_corporation_id_divisions";
                public const string Facilities =                      "get_corporations_corporation_id_facilities";
                public const string Icons =                           "get_corporations_corporation_id_icons";
                public const string Medals =                          "get_corporations_corporation_id_medals";
                public const string IssuedMedals =                    "get_corporations_corporation_id_medals_issued";
                public const string Members =                         "get_corporations_corporation_id_members";
                public const string MembersLimit =                    "get_corporations_corporation_id_members_limit";
                public const string MembersTitles =                   "get_corporations_corporation_id_members_titles";
                public const string MemberTracking =                  "get_corporations_corporation_id_membertracking";
                public const string Roles =                           "get_corporations_corporation_id_roles";
                public const string RolesHistory =                    "get_corporations_corporation_id_roles_history";
                public const string Shareholders =                    "get_corporations_corporation_id_shareholders";
                public const string Standings =                       "get_corporations_corporation_id_standings";
                public const string Starbases =                       "get_corporations_corporation_id_starbases";
                public const string StarbaseInfo =                    "get_corporations_corporation_id_starbases_starbase";
                public const string Structures =                      "get_corporations_corporation_id_structures";
                public const string Titles =                          "get_corporations_corporation_id_titles";
                public const string NpcCorporations =                 "get_corporations_npccorps";
            }

            public static class Dogma
            {
                public const string Attributes =                      "get_dogma_attributes";
                public const string AttributeInfo =                   "get_dogma_attributes_attribute_id";
                public const string DynamicItemInfo =                 "get_dogma_dynamic_items_type_id_item_id";
                public const string Effects =                         "get_dogma_effects";
                public const string EffectInfo =                      "get_dogma_effects_effect_id";
            }

            public static class FactionWarfare
            {
                public const string CharacterStats =                  "get_characters_character_id_fw_stats";
                public const string CorporationStats =                "get_corporations_corporation_id_fw_stats";
                public const string FactionsLeaderboard =             "get_fw_leaderboards";
                public const string CaractersLeaderboard =            "get_fw_leaderboards_characters";
                public const string CorporationsLeaderboard =         "get_fw_leaderboards_corporations";
                public const string FactionsStats =                   "get_fw_stats";
                public const string OwnershipSystemOverview =         "get_fw_systems";
                public const string Wars =                            "get_fw_wars";
            }

            public static class Fittings
            {
                public const string GetFittings =                     "get_characters_character_id_fittings";
                public const string DeleteFitting =                   "delete_characters_character_id_fitting_id_fittings";
                public const string NewFitting =                      "post_characters_character_id_fittings";
            }

            public static class Fleets
            {
                public const string FleetInfo =                       "get_characters_character_id_fleet";
                public const string FleetSettings =                   "get_fleets_fleet_id";
                public const string UpdateFleetSettings =             "put_fleets_fleet_id";
                public const string FleetMembers =                    "get_fleets_fleet_id_members";
                public const string InviteMember =                    "post_fleets_fleet_id_members";
                public const string KickMember =                      "delete_fleets_fleet_id_members_member_id";
                public const string MoveMember =                      "put_fleets_fleet_id_members_member_id";
                public const string DeleteSquad =                     "delete_fleets_fleet_id_squads_squad_id";
                public const string RenameSquad =                     "put_fleets_fleet_id_squads_squad_id";
                public const string FleetWings =                      "get_fleets_fleet_id_wings";
                public const string NewWing =                         "post_fleets_fleet_id_wings";
                public const string DeleteWing =                      "delete_fleets_fleet_id_wings_wing_id";
                public const string RenameWing =                      "put_fleets_fleet_id_wings_wing_id";
                public const string NewSquad =                        "post_fleets_fleet_id_wings_wing_id_squads";
            }

            public static class Incursions
            {
                public const string IncursionList =                   "get_incursions";
            }

            public static class Industry
            {
                public const string CharacterJobs =                   "get_characters_character_id_industry_jobs";
                public const string CharacterMiningLedger =           "get_characters_character_id_mining";
                public const string ExtractionTimers =                "get_corporation_corporation_id_mining_extractions";
                public const string CorporationObservers =            "get_corporation_corporation_id_mining_observers";
                public const string ObserverInfo =                    "get_corporation_corporation_id_mining_observers_observer_id";
                public const string CorporationJobs =                 "get_corporations_corporation_id_industry_jobs";
                public const string Facilities =                      "get_industry_facilities";
                public const string SolarSystems =                    "get_industry_systems";
            }

            public static class Insurence
            {
                public const string InsuranceLevels =                 "get_insurance_prices";
            }

            public static class Killmails
            {
                public const string CharacterKillmails =              "get_characters_character_id_killmails_recent";
                public const string CorporationKillmails =            "get_corporations_corporation_id_killmails_recent";
                public const string KillmailInfo =                    "get_killmails_killmail_id_killmail_hash";
            }

            public static class Location
            {
                public const string CurrentLocation =                 "get_characters_character_id_location";
                public const string Online =                          "get_characters_character_id_online";
                public const string CurrentShip =                     "get_characters_character_id_ship";
            }

            public static class Loyalty
            {
                public const string LoyaltyPoints =                   "get_characters_character_id_loyalty_points";
                public const string CorporationOffers =               "get_loyalty_stores_corporation_id_offers";
            }

            public static class Mail
            {
                public const string MailHeaders =                     "get_characters_character_id_mail";
                public const string SendMail =                        "post_characters_character_id_mail";
                public const string DeleteMail =                      "delete_characters_character_id_mail_mail_id";
                public const string GetMail =                         "get_characters_character_id_mail_mail_id";
                public const string UpdateMail =                      "put_characters_character_id_mail_mail_id";
                public const string GetLabels =                       "get_characters_character_id_mail_labels";
                public const string CreateLabel =                     "post_characters_character_id_mail_labels";
                public const string DeleteLabel =                     "delete_characters_character_id_mail_labels_label_id";
                public const string MailingList =                     "get_characters_character_id_mail_lists";
            }

            public static class Market
            {
                public const string CharacterOrders =                 "get_characters_character_id_orders";
                public const string CharacterOrdersHistory =          "get_characters_character_id_orders_history";
                public const string CorporationOrders =               "get_corporations_corporation_id_orders";
                public const string CorporationOrdersHistory =        "get_corporations_corporation_id_orders_history";
                public const string RegionStatistics =                "get_markets_region_id_history";
                public const string RegionOrders =                    "get_markets_region_id_orders";
                public const string ActiveRegionOrderTypes =          "get_markets_region_id_types";
                public const string MarketGroups =                    "get_markets_groups";
                public const string MarketGroupInfo =                 "get_markets_groups_market_group_id";
                public const string TypePrices =                      "get_markets_prices";
                public const string StructureOrders =                 "get_markets_structures_structure_id";
            }
        }
    }
}
