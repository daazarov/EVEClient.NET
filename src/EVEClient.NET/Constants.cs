using EVEClient.NET.Configuration;
using System.Collections.Generic;
using System;

namespace EVEClient.NET
{
    public class ESI
    {
        internal const string HttpClientName = "EsiHttpClient";
        internal const string EsiBaseUrl = "https://esi.evetech.net";

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
                public const string ActiveAlliances =                 "get_alliance";
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
                public const string AllianceContacts =                "get_alliances_alliance_id_contacts";
                public const string AllianceContactLabels =           "get_alliances_alliance_id_contacts_labels";
                public const string DeleteCharacterContacts =         "delete_characters_character_id_contacts";
                public const string CharacterContacts =               "get_characters_character_id_contacts";
                public const string AddCharacterContacts =            "post_characters_character_id_contacts";
                public const string UpdateCharacterContacts =         "put_characters_character_id_contacts";
                public const string CharacterContactLabels =          "get_characters_character_id_contacts_labels";
                public const string CorporationContacts =             "get_corporations_corporation_id_contacts";
                public const string CorporationContactLabels =        "get_corporations_corporation_id_contacts_labels";
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

            public static class PlanetaryInteraction
            {
                public const string Colonies =                        "get_characters_character_id_planets";
                public const string ColonyInfo =                      "get_characters_character_id_planets_planet_id";
                public const string CustomOffices =                   "get_corporations_corporation_id_customs_offices";
                public const string SchematicInfo =                   "get_universe_schematics_schematic_id";
            }

            public static class Routes
            {
                public const string Route =                           "get_route_origin_destination";
            }

            public static class Search
            {
                public const string Query =                           "get_characters_character_id_search";
            }

            public static class Skills
            {
                public const string Attributes =                      "get_characters_character_id_attributes";
                public const string SkillQueue =                      "get_characters_character_id_skillqueue";
                public const string SkillDetails =                    "get_characters_character_id_skills";
            }

            public static class Sovereignty
            {
                public const string Campaigns =                       "get_sovereignty_campaigns";
                public const string SolarSystems =                    "get_sovereignty_map";
                public const string Structures =                      "get_sovereignty_structures";
            }

            public static class Status
            {
                public const string ServerStatus =                    "get_status";
            }

            public static class Universe
            {
                public const string Ancestries =                      "get_universe_ancestries";
                public const string AsteroidBeltInfo =                "get_universe_asteroid_belts_asteroid_belt_id";
                public const string Bloodlines =                      "get_universe_bloodlines";
                public const string ItemCategories =                  "get_universe_categories";
                public const string ItemCategoryInfo =                "get_universe_categories_category_id";
                public const string Constellations =                  "get_universe_constellations";
                public const string ConstellationInfo =               "get_universe_constellations_constellation_id";
                public const string Factions =                        "get_universe_factions";
                public const string Graphics =                        "get_universe_graphics";
                public const string GraphicInfo =                     "get_universe_graphics_graphic_id";
                public const string ItemGroups =                      "get_universe_groups";
                public const string ItemGroupInfo =                   "get_universe_groups_group_id";
                public const string IDs =                             "post_universe_ids";
                public const string MoonInfo =                        "get_universe_moons_moon_id";
                public const string Names =                           "post_universe_names";
                public const string PlanetInfo =                      "get_universe_planets_planet_id";
                public const string Races =                           "get_universe_races";
                public const string Regions =                         "get_universe_regions";
                public const string RegionInfo =                      "get_universe_regions_region_id";
                public const string StargateInfo =                    "get_universe_stargates_stargate_id";
                public const string StarInfo =                        "get_universe_stars_star_id";
                public const string StationInfo =                     "get_universe_stations_station_id";
                public const string Structures =                      "get_universe_structures";
                public const string StructureInfo =                   "get_universe_structures_structure_id";
                public const string SystemJumps =                     "get_universe_system_jumps";
                public const string SystemKills =                     "get_universe_system_kills";
                public const string SolarSystems =                    "get_universe_systems";
                public const string SolarSystemInfo =                 "get_universe_systems_system_id";
                public const string Types =                           "get_universe_types";
                public const string TypeInfo =                        "get_universe_types_type_id";
            }

            public static class UserInterface
            {
                public const string SetAutopilotWaypoint =            "post_ui_autopilot_waypoint";
                public const string OpenContractWindow =              "post_ui_openwindow_contractwindow";
                public const string OpenInformationWindow =           "post_ui_openwindow_ingormationwindow";
                public const string OpenMarketDetails =               "post_ui_openwindow_marketdetails";
                public const string OpenNewMailWindow =               "post_ui_openwindow_newmail";
            }

            public static class Wallet
            {
                public const string WalletBalance =                   "get_characters_character_id_wallet";
                public const string WalletJournal =                   "get_characters_character_id_wallet_journal";
                public const string WalletTransactions =              "get_characters_character_id_wallet_transactions";
                public const string CorporationWallets =              "get_corporations_corporation_id_wallets";
                public const string CorporationWalletJournal =        "get_corporations_corporation_id_wallets_division_journal";
                public const string CorporationWalletTransactions =   "get_corporations_corporation_id_wallets_division_transactions";
            }

            public static class Wars
            {
                public const string WarList =                         "get_wars";
                public const string WarDetails =                      "get_wars_war_id";
                public const string Kills =                           "get_wars_war_id_killmails";
            }

            internal static class Configurations
            {
                internal static IDictionary<string, Action<EndpointConfigurationBuilder>> Default =>
                    new Dictionary<string, Action<EndpointConfigurationBuilder>>
                    {
                        #region Alliance
                        {
                            ESI.Endpoints.Alliances.PublicInformation, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/", EndpointVersion.Latest, false),
                                    new("/v3/alliances/{alliance_id}/", EndpointVersion.V3, true),
                                    new("/v4/alliances/{alliance_id}/", EndpointVersion.V4, true),
                                    new("/legacy/alliances/{alliance_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/alliances/{alliance_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Alliances.CorporationsInAlliance, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/corporations/", EndpointVersion.Latest, false),
                                    new("/v1/alliances/{alliance_id}/corporations/", EndpointVersion.V1, true),
                                    new("/v2/alliances/{alliance_id}/corporations/", EndpointVersion.V2, true),
                                    new("/legacy/alliances/{alliance_id}/corporations/", EndpointVersion.Legacy, false),
                                    new("/dev/alliances/{alliance_id}/corporations/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Alliances.ActiveAlliances, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/alliances/", EndpointVersion.Latest, false),
                                    new("/v1/alliances/", EndpointVersion.V1, true),
                                    new("/v2/alliances/", EndpointVersion.V2, true),
                                    new("/legacy/alliances/", EndpointVersion.Legacy, false),
                                    new("/dev/alliances/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Alliances.AllianceIcon, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/icons/", EndpointVersion.Latest, false),
                                    new("/v1/alliances/{alliance_id}/icons/", EndpointVersion.V1, true),
                                    new("/legacy/alliances/{alliance_id}/icons/", EndpointVersion.Legacy, false),
                                    new("/dev/alliances/{alliance_id}/icons/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Assets
                        {
                            ESI.Endpoints.Assets.CharacterAssetList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/assets/", EndpointVersion.Latest, false),
                                    new("/v5/characters/{character_id}/assets/", EndpointVersion.V5, true),
                                    new("/dev/characters/{character_id}/assets/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Assets.CorporationAssetList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_corporation_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/assets/", EndpointVersion.Latest, false),
                                    new("/v5/corporations/{corporation_id}/assets/", EndpointVersion.V5, true),
                                    new("/dev/corporations/{corporation_id}/assets/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Assets.LocationAssets, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/assets/locations/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/assets/locations/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/assets/locations/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Assets.AssetItemNames, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/assets/names/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/assets/names/", EndpointVersion.V1, true),
                                    new("/dev/characters/{character_id}/assets/names/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/assets/names/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Assets.CorporationLocationAssets, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_corporation_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/assets/locations/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/assets/locations/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/assets/locations/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Assets.CorporationAssetItemNames, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-assets.read_corporation_assets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/assets/names/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/assets/names/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/assets/names/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/assets/names/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Calendar
                        {
                            ESI.Endpoints.Calendar.CalendarItems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-calendar.read_calendar_events.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/calendar/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/calendar/", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/calendar/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/calendar/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/calendar/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Calendar.CalendarEvent, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-calendar.read_calendar_events.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/calendar/{event_id}/", EndpointVersion.V3, true),
                                    new("/v4/characters/{character_id}/calendar/{event_id}/", EndpointVersion.V4, true),
                                    new("/dev/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Calendar.RespondeEvent, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-calendar.respond_calendar_events.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/calendar/{event_id}/", EndpointVersion.V3, true),
                                    new("/v4/characters/{character_id}/calendar/{event_id}/", EndpointVersion.V4, true),
                                    new("/dev/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/calendar/{event_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Calendar.EventAttendees, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-calendar.read_calendar_events.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/calendar/{event_id}/attendees/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/calendar/{event_id}/attendees/", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/calendar/{event_id}/attendees/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/calendar/{event_id}/attendees/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/calendar/{event_id}/attendees/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Character
                        {
                            ESI.Endpoints.Characters.PublicInformation, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/", EndpointVersion.Latest, false),
                                    new("/v5/characters/{character_id}/", EndpointVersion.V5, true),
                                    new("/legacy/characters/{character_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Standings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_standings.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/standings/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/standings/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/standings/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.AgentsResearch, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_agents_research.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/agents_research/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/agents_research/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/agents_research/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Blueprints, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_blueprints.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/blueprints/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/blueprints/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/blueprints/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.CorporationHistory, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/corporationhistory/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/corporationhistory/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/corporationhistory/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.CSPA, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/cspa/", EndpointVersion.Latest, false),
                                    new("/v5/characters/{character_id}/cspa/", EndpointVersion.V5, true),
                                    new("/dev/characters/{character_id}/cspa/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Fatigue, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_fatigue.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fatigue/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/fatigue/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/fatigue/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Medals, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_medals.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/medals/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/medals/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/medals/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Notifications, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_notifications.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/notifications/", EndpointVersion.Latest, false),
                                    new("/v5/characters/{character_id}/notifications/", EndpointVersion.V5, true),
                                    new("/v6/characters/{character_id}/notifications/", EndpointVersion.V6, true),
                                    new("/dev/characters/{character_id}/notifications/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.ContactNotifications, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_notifications.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/notifications/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/notifications/contacts/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/notifications/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Portrait, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/portrait/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/portrait/", EndpointVersion.V2, true),
                                    new("/v3/characters/{character_id}/portrait/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/portrait/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Roles, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_corporation_roles.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/roles/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/roles/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/roles/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Titles, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_titles.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/titles/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/titles/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/titles/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Characters.Affilation, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.Routes =
                                [
                                    new("/latest/characters/affiliation/", EndpointVersion.Latest, false),
                                    new("/v2/characters/affiliation/", EndpointVersion.V2, true),
                                    new("/dev/characters/affiliation/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Clones
                        {
                            ESI.Endpoints.Clones.CloneImplants, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-clones.read_implants.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/implants/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/implants/", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/implants/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/implants/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/implants/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Clones.CloneList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-clones.read_clones.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/clones/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/clones/", EndpointVersion.V3, true),
                                    new("/v4/characters/{character_id}/clones/", EndpointVersion.V4, true),
                                    new("/dev/characters/{character_id}/clones/", EndpointVersion.Dev, false),
                                ];
                            }
                        },
                        #endregion

                        #region Contacts
                        {
                            ESI.Endpoints.Contacts.AllianceContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-alliances.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/alliances/{alliance_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/alliances/{alliance_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.AllianceContactLabels, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-alliances.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v1/alliances/{alliance_id}/contacts/", EndpointVersion.V1, true),
                                    new("/dev/alliances/{alliance_id}/contacts/", EndpointVersion.Dev, false),
                                    new("/legacy/alliances/{alliance_id}/contacts/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.DeleteCharacterContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.write_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.CharacterContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.AddCharacterContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.write_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.UpdateCharacterContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.write_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.CharacterContactLabels, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/alliances/{alliance_id}/contacts/labels/", EndpointVersion.Latest, false),
                                    new("/v1/alliances/{alliance_id}/contacts/labels/", EndpointVersion.V1, true),
                                    new("/dev/alliances/{alliance_id}/contacts/labels/", EndpointVersion.Dev, false),
                                    new("/legacy/alliances/{alliance_id}/contacts/labels/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.CorporationContacts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/contacts/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/contacts/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/contacts/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contacts.CorporationContactLabels, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_contacts.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/contacts/labels/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/contacts/labels/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/contacts/labels/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/contacts/labels/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Contracts
                        {
                            ESI.Endpoints.Contracts.CharacterContracts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_character_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contracts/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/contracts/", EndpointVersion.V1, true),
                                    new("/dev/characters/{character_id}/contracts/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/contracts/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.CharacterContractBids, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_character_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contracts/{contract_id}/bids/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/contracts/{contract_id}/bids/", EndpointVersion.V1, true),
                                    new("/dev/characters/{character_id}/contracts/{contract_id}/bids/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/contracts/{contract_id}/bids/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.CharacterContractItems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_character_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/contracts/{contract_id}/items/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/contracts/{contract_id}/items/", EndpointVersion.V1, true),
                                    new("/dev/characters/{character_id}/contracts/{contract_id}/items/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/contracts/{contract_id}/items/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.PublicContracts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/contracts/public/{region_id}/", EndpointVersion.Latest, false),
                                    new("/v1/contracts/public/{region_id}/", EndpointVersion.V1, true),
                                    new("/dev/contracts/public/{region_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/contracts/public/{region_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.PublicContractBids, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/contracts/public/bids/{contract_id}/", EndpointVersion.Latest, false),
                                    new("/v1/contracts/public/bids/{contract_id}/", EndpointVersion.V1, true),
                                    new("/dev/contracts/public/bids/{contract_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/contracts/public/bids/{contract_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.PublicContractItems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/contracts/public/items/{contract_id}/", EndpointVersion.Latest, false),
                                    new("/v1/contracts/public/items/{contract_id}/", EndpointVersion.V1, true),
                                    new("/dev/contracts/public/items/{contract_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/contracts/public/items/{contract_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.CorporationContracts, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_corporation_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/contracts/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/contracts/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/contracts/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/contracts/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.CorporationContractBids, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_corporation_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/contracts/{contract_id}/bids/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/contracts/{contract_id}/bids/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/contracts/{contract_id}/bids/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/contracts/{contract_id}/bids/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Contracts.CorporationContractItems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-contracts.read_corporation_contracts.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/contracts/{contract_id}/items/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/contracts/{contract_id}/items/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/contracts/{contract_id}/items/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/contracts/{contract_id}/items/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Corporation
                        {
                            ESI.Endpoints.Corporation.Information, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/", EndpointVersion.Latest, false),
                                    new("/v5/corporations/{corporation_id}/", EndpointVersion.V5, true),
                                    new("/dev/corporations/{corporation_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.AllianceHistory, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/alliancehistory/", EndpointVersion.Latest, false),
                                    new("/v3/corporations/{corporation_id}/alliancehistory/", EndpointVersion.V3, true),
                                    new("/dev/corporations/{corporation_id}/alliancehistory/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Blueprints, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_blueprints.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/blueprints/", EndpointVersion.Latest, false),
                                    new("/v3/corporations/{corporation_id}/blueprints/", EndpointVersion.V3, true),
                                    new("/dev/corporations/{corporation_id}/blueprints/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.ContainersLogs, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_container_logs.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/containers/logs/", EndpointVersion.Latest, false),
                                    new("/v3/corporations/{corporation_id}/containers/logs/", EndpointVersion.V3, true),
                                    new("/dev/corporations/{corporation_id}/containers/logs/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Divisions, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_divisions.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/divisions/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/divisions/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/divisions/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Facilities, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_facilities.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/facilities/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/facilities/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/facilities/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Icons, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/icons/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/icons/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/icons/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Medals, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_medals.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/medals", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/medals", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/medals", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.IssuedMedals, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_medals.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/medals/issued/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/medals/issued/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/medals/issued/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Members, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_corporation_membership.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/members/", EndpointVersion.Latest, false),
                                    new("/v4/corporations/{corporation_id}/members/", EndpointVersion.V4, true),
                                    new("/dev/corporations/{corporation_id}/members/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.MembersLimit, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.track_members.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/members/limit/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/members/limit/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/members/limit/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.MembersTitles, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_titles.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/members/titles/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/members/titles/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/members/titles/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.MemberTracking, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.track_members.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/membertracking/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/membertracking/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/membertracking/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Roles, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_corporation_membership.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/roles/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/roles/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/roles/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.RolesHistory, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_corporation_membership.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/roles/history/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/roles/history/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/roles/history/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Shareholders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_corporation_wallets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/shareholders/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/shareholders/", EndpointVersion.V1, true),
                                    new("/dev/corporations/{corporation_id}/shareholders/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/shareholders/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Standings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_standings.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/standings/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/standings/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/standings/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Starbases, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_starbases.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/starbases/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/starbases/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/starbases/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.StarbaseInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_starbases.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/starbases/{starbase_id}/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/starbases/{starbase_id}/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/starbases/{starbase_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Structures, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_structures.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/structures/", EndpointVersion.Latest, false),
                                    new("/v4/corporations/{corporation_id}/structures/", EndpointVersion.V4, true),
                                    new("/dev/corporations/{corporation_id}/structures/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.Titles, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_titles.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/titles/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/titles/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/titles/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Corporation.NpcCorporations, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/corporations/npccorps/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/npccorps/", EndpointVersion.V2, true),
                                    new("/dev/corporations/npccorps/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Dogma
                        {
                            ESI.Endpoints.Dogma.Attributes, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/dogma/attributes/", EndpointVersion.Latest, false),
                                    new("/v1/dogma/attributes/", EndpointVersion.V1, true),
                                    new("/dev/dogma/attributes/", EndpointVersion.Dev, false),
                                    new("/legacy/dogma/attributes/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Dogma.AttributeInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/dogma/attributes/{attribute_id}/", EndpointVersion.Latest, false),
                                    new("/v1/dogma/attributes/{attribute_id}/", EndpointVersion.V1, true),
                                    new("/dev/dogma/attributes/{attribute_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/dogma/attributes/{attribute_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Dogma.DynamicItemInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/dogma/dynamic/items/{type_id}/{item_id}/", EndpointVersion.Latest, false),
                                    new("/v1/dogma/dynamic/items/{type_id}/{item_id}/", EndpointVersion.V1, true),
                                    new("/dev/dogma/dynamic/items/{type_id}/{item_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/dogma/dynamic/items/{type_id}/{item_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Dogma.Effects, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/dogma/effects/", EndpointVersion.Latest, false),
                                    new("/v1/dogma/effects/", EndpointVersion.V1, true),
                                    new("/dev/dogma/effects/", EndpointVersion.Dev, false),
                                    new("/legacy/dogma/effects/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Dogma.EffectInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/dogma/effects/{effect_id}/", EndpointVersion.Latest, false),
                                    new("/v2/dogma/effects/{effect_id}/", EndpointVersion.V2, true),
                                    new("/dev/dogma/effects/{effect_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region FactionWarfare
                        {
                            ESI.Endpoints.FactionWarfare.CharacterStats, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_fw_stats.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fw/stats/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/fw/stats/", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/fw/stats/", EndpointVersion.V2, false),
                                    new("/dev/characters/{character_id}/fw/stats/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/fw/stats/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.CorporationStats, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-corporations.read_fw_stats.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/fw/stats/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/fw/stats/", EndpointVersion.V1, true),
                                    new("/v2/corporations/{corporation_id}/fw/stats/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/fw/stats/", EndpointVersion.Dev, false),
                                    new("/legacy/corporations/{corporation_id}/fw/stats/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.FactionsLeaderboard, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/fw/leaderboards/", EndpointVersion.Latest, false),
                                    new("/v1/fw/leaderboards/", EndpointVersion.V1, true),
                                    new("/v2/fw/leaderboards/", EndpointVersion.V2, true),
                                    new("/dev/fw/leaderboards/", EndpointVersion.Dev, false),
                                    new("/legacy/fw/leaderboards/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.CaractersLeaderboard, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/fw/leaderboards/characters/", EndpointVersion.Latest, false),
                                    new("/v1/fw/leaderboards/characters/", EndpointVersion.V1, true),
                                    new("/v2/fw/leaderboards/characters/", EndpointVersion.V2, true),
                                    new("/dev/fw/leaderboards/characters/", EndpointVersion.Dev, false),
                                    new("/legacy/fw/leaderboards/characters/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.CorporationsLeaderboard, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/fw/leaderboards/corporations/", EndpointVersion.Latest, false),
                                    new("/v1/fw/leaderboards/corporations/", EndpointVersion.V1, true),
                                    new("/v2/fw/leaderboards/corporations/", EndpointVersion.V2, true),
                                    new("/dev/fw/leaderboards/corporations/", EndpointVersion.Dev, false),
                                    new("/legacy/fw/leaderboards/corporations/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.OwnershipSystemOverview, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/fw/systems/", EndpointVersion.Latest, false),
                                    new("/v2/fw/systems/", EndpointVersion.V2, true),
                                    new("/v3/fw/systems/", EndpointVersion.V3, true),
                                    new("/dev/fw/systems/", EndpointVersion.Dev, false),
                                    new("/legacy/fw/systems/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.FactionWarfare.Wars, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/fw/wars/", EndpointVersion.Latest, false),
                                    new("/v1/fw/wars/", EndpointVersion.V1, true),
                                    new("/v2/fw/wars/", EndpointVersion.V2, true),
                                    new("/dev/fw/wars/", EndpointVersion.Dev, false),
                                    new("/legacy/fw/wars/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Fittings
                        {
                            ESI.Endpoints.Fittings.GetFittings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fittings.read_fittings.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fittings/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/fittings/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/fittings/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fittings.NewFitting, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fittings.write_fittings.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fittings/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/fittings/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/fittings/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fittings.DeleteFitting, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fittings.write_fittings.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fittings/{fitting_id}/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/fittings/{fitting_id}/", EndpointVersion.V1, true),
                                    new("/dev/characters/{character_id}/fittings/{fitting_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/characters/{character_id}/fittings/{fitting_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Fleets
                        {
                            ESI.Endpoints.Fleets.FleetInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.read_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/fleet/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/fleet/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/fleet/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.FleetSettings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.read_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.UpdateFleetSettings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.FleetMembers, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.read_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/members/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/members/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/members/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/members/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.InviteMember, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/members/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/members/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/members/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/members/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.KickMember, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.MoveMember, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/members/{member_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.DeleteSquad, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.RenameSquad, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/squads/{squad_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.FleetWings, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.read_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/wings/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/wings/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/wings/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/wings/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.NewWing, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/wings/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/wings/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/wings/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/wings/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.DeleteWing, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.RenameWing, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/wings/{wing_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Fleets.NewSquad, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-fleets.write_fleet.v1";
                                builder.Routes =
                                [
                                    new("/latest/fleets/{fleet_id}/wings/{wing_id}/squads/", EndpointVersion.Latest, false),
                                    new("/v1/fleets/{fleet_id}/wings/{wing_id}/squads/", EndpointVersion.V1, true),
                                    new("/dev/fleets/{fleet_id}/wings/{wing_id}/squads/", EndpointVersion.Dev, false),
                                    new("/legacy/fleets/{fleet_id}/wings/{wing_id}/squads/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Incursions
                        {
                            ESI.Endpoints.Incursions.IncursionList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.Routes =
                                [
                                    new("/latest/incursions/", EndpointVersion.Latest, false),
                                    new("/v1/incursions/", EndpointVersion.V1, true),
                                    new("/dev/incursions/", EndpointVersion.Dev, false),
                                    new("/legacy/incursions/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        #endregion

                        #region Industry
                        {
                            ESI.Endpoints.Industry.CharacterJobs, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_character_jobs.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/industry/jobs/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/industry/jobs/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/industry/jobs/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/industry/jobs/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.CharacterMiningLedger, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_character_mining.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mining/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mining/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mining/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mining/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.ExtractionTimers, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_corporation_mining.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporation/{corporation_id}/mining/extractions/", EndpointVersion.Latest, false),
                                    new("/v1/corporation/{corporation_id}/mining/extractions/", EndpointVersion.V1, true),
                                    new("/legacy/corporation/{corporation_id}/mining/extractions/", EndpointVersion.Legacy, false),
                                    new("/dev/corporation/{corporation_id}/mining/extractions/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.CorporationObservers, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_corporation_mining.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporation/{corporation_id}/mining/observers/", EndpointVersion.Latest, false),
                                    new("/v1/corporation/{corporation_id}/mining/observers/", EndpointVersion.V1, true),
                                    new("/legacy/corporation/{corporation_id}/mining/observers/", EndpointVersion.Legacy, false),
                                    new("/dev/corporation/{corporation_id}/mining/observers/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.ObserverInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_corporation_mining.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporation/{corporation_id}/mining/observers/{observer_id}/", EndpointVersion.Latest, false),
                                    new("/v1/corporation/{corporation_id}/mining/observers/{observer_id}/", EndpointVersion.V1, true),
                                    new("/legacy/corporation/{corporation_id}/mining/observers/{observer_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/corporation/{corporation_id}/mining/observers/{observer_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.CorporationJobs, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-industry.read_corporation_jobs.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/industry/jobs/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/industry/jobs/", EndpointVersion.V1, true),
                                    new("/legacy/corporations/{corporation_id}/industry/jobs/", EndpointVersion.Legacy, false),
                                    new("/dev/corporations/{corporation_id}/industry/jobs/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.Facilities, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/industry/facilities/", EndpointVersion.Latest, false),
                                    new("/v1/industry/facilities/", EndpointVersion.V1, true),
                                    new("/legacy/industry/facilities/", EndpointVersion.Legacy, false),
                                    new("/dev/industry/facilities/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Industry.SolarSystems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/industry/systems/", EndpointVersion.Latest, false),
                                    new("/v1/industry/systems/", EndpointVersion.V1, true),
                                    new("/legacy/industry/systems/", EndpointVersion.Legacy, false),
                                    new("/dev/industry/systems/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Insurance
                        {
                            ESI.Endpoints.Insurence.InsuranceLevels, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/insurance/prices/", EndpointVersion.Latest, false),
                                    new("/v1/insurance/prices/", EndpointVersion.V1, true),
                                    new("/legacy/insurance/prices/", EndpointVersion.Legacy, false),
                                    new("/dev/insurance/prices/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Killmails
                        {
                            ESI.Endpoints.Killmails.CharacterKillmails, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-killmails.read_killmails.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/killmails/recent/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/killmails/recent/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/killmails/recent/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/killmails/recent/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Killmails.CorporationKillmails, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-killmails.read_corporation_killmails.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/killmails/recent/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/killmails/recent/", EndpointVersion.V1, true),
                                    new("/legacy/corporations/{corporation_id}/killmails/recent/", EndpointVersion.Legacy, false),
                                    new("/dev/corporations/{corporation_id}/killmails/recent/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Killmails.KillmailInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/killmails/{killmail_id}/{killmail_hash}/", EndpointVersion.Latest, false),
                                    new("/v1/killmails/{killmail_id}/{killmail_hash}/", EndpointVersion.V1, true),
                                    new("/legacy/killmails/{killmail_id}/{killmail_hash}/", EndpointVersion.Legacy, false),
                                    new("/dev/killmails/{killmail_id}/{killmail_hash}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Location
                        {
                            ESI.Endpoints.Location.CurrentLocation, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-location.read_location.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/location", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/location", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/location", EndpointVersion.V2, true),
                                    new("/legacy/characters/{character_id}/location", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/location", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Location.Online, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-location.read_online.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/online/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/online/", EndpointVersion.V2, true),
                                    new("/v3/characters/{character_id}/online/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/online/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Location.CurrentShip, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-location.read_ship_type.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/ship/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/ship/", EndpointVersion.V1, true),
                                    new("/v2/characters/{character_id}/ship/", EndpointVersion.V2, true),
                                    new("/legacy/characters/{character_id}/ship/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/ship/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Loyalty
                        {
                            ESI.Endpoints.Loyalty.LoyaltyPoints, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-characters.read_loyalty.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/loyalty/points/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/loyalty/points/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/loyalty/points/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/loyalty/points/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Loyalty.CorporationOffers, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/loyalty/stores/{corporation_id}/offers/", EndpointVersion.Latest, false),
                                    new("/v1/loyalty/stores/{corporation_id}/offers/", EndpointVersion.V1, true),
                                    new("/legacy/loyalty/stores/{corporation_id}/offers/", EndpointVersion.Legacy, false),
                                    new("/dev/loyalty/stores/{corporation_id}/offers/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Mail
                        {
                            ESI.Endpoints.Mail.MailHeaders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.read_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.SendMail, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.send_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.DeleteMail, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.organize_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/{mail_id}/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.GetMail, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.read_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/{mail_id}/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.UpdateMail, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Put;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.organize_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/{mail_id}/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/{mail_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.GetLabels, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.read_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/labels/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/mail/labels/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/mail/labels/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.CreateLabel, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.organize_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/labels/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/mail/labels/", EndpointVersion.V2, true),
                                    new("/legacy/characters/{character_id}/mail/labels/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/labels/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.DeleteLabel, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Delete;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.organize_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/labels/{label_id}/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/labels/{label_id}/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/labels/{label_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/labels/{label_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Mail.MailingList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-mail.read_mail.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/mail/lists/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/mail/lists/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/mail/lists/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/mail/lists/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Market
                        {
                            ESI.Endpoints.Market.CharacterOrders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-markets.read_character_orders.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/orders/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/orders/", EndpointVersion.V2, true),
                                    new("/dev/characters/{character_id}/orders/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.CharacterOrdersHistory, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-markets.read_character_orders.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/orders/history/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/orders/history/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/orders/history/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/orders/history/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.CorporationOrders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-markets.read_corporation_orders.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/orders/", EndpointVersion.Latest, false),
                                    new("/v3/corporations/{corporation_id}/orders/", EndpointVersion.V3, true),
                                    new("/dev/corporations/{corporation_id}/orders/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.CorporationOrdersHistory, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-markets.read_corporation_orders.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/orders/history/", EndpointVersion.Latest, false),
                                    new("/v2/corporations/{corporation_id}/orders/history/", EndpointVersion.V2, true),
                                    new("/dev/corporations/{corporation_id}/orders/history/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.RegionStatistics, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/{region_id}/history/", EndpointVersion.Latest, false),
                                    new("/v1/markets/{region_id}/history/", EndpointVersion.V1, true),
                                    new("/legacy/markets/{region_id}/history/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/{region_id}/history/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.RegionOrders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/{region_id}/orders/", EndpointVersion.Latest, false),
                                    new("/v1/markets/{region_id}/orders/", EndpointVersion.V1, true),
                                    new("/legacy/markets/{region_id}/orders/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/{region_id}/orders/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.ActiveRegionOrderTypes, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/{region_id}/types/", EndpointVersion.Latest, false),
                                    new("/v1/markets/{region_id}/types/", EndpointVersion.V1, true),
                                    new("/legacy/markets/{region_id}/types/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/{region_id}/types/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.MarketGroups, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/groups/", EndpointVersion.Latest, false),
                                    new("/v1/markets/groups/", EndpointVersion.V1, true),
                                    new("/legacy/markets/groups/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/groups/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.MarketGroupInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/groups/{market_group_id}/", EndpointVersion.Latest, false),
                                    new("/v1/markets/groups/{market_group_id}/", EndpointVersion.V1, true),
                                    new("/legacy/markets/groups/{market_group_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/groups/{market_group_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.TypePrices, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/markets/prices/", EndpointVersion.Latest, false),
                                    new("/v1/markets/prices/", EndpointVersion.V1, true),
                                    new("/legacy/markets/prices/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/prices/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Market.StructureOrders, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-markets.structure_markets.v1";
                                builder.Routes =
                                [
                                    new("/latest/markets/structures/{structure_id}/", EndpointVersion.Latest, false),
                                    new("/v1/markets/structures/{structure_id}/", EndpointVersion.V1, true),
                                    new("/legacy/markets/structures/{structure_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/markets/structures/{structure_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region PlanetaryInteraction
                        {
                            ESI.Endpoints.PlanetaryInteraction.Colonies, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-planets.manage_planets.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/planets/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/planets/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/planets/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/planets/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.PlanetaryInteraction.ColonyInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-planets.manage_planets.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/planets/{planet_id}/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/planets/{planet_id}/", EndpointVersion.V3, true),
                                    new("/dev/characters/{character_id}/planets/{planet_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.PlanetaryInteraction.CustomOffices, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-planets.read_customs_offices.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/customs_offices/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/customs_offices/", EndpointVersion.V1, true),
                                    new("/legacy/corporations/{corporation_id}/customs_offices/", EndpointVersion.Legacy, false),
                                    new("/dev/corporations/{corporation_id}/customs_offices/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.PlanetaryInteraction.SchematicInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/schematics/{schematic_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/schematics/{schematic_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/schematics/{schematic_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/schematics/{schematic_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Routes
                        {
                            ESI.Endpoints.Routes.Route, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/route/{origin}/{destination}/", EndpointVersion.Latest, false),
                                    new("/v1/route/{origin}/{destination}/", EndpointVersion.V1, true),
                                    new("/legacy/route/{origin}/{destination}/", EndpointVersion.Legacy, false),
                                    new("/dev/route/{origin}/{destination}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Search
                        {
                            ESI.Endpoints.Search.Query, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-search.search_structures.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/search/", EndpointVersion.Latest, false),
                                    new("/v3/characters/{character_id}/search/", EndpointVersion.V3, true),
                                    new("/legacy/characters/{character_id}/search/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/search/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Skills
                        {
                            ESI.Endpoints.Skills.Attributes, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-skills.read_skills.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/attributes/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/attributes/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/attributes/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/attributes/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Skills.SkillQueue, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-skills.read_skillqueue.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/skillqueue/", EndpointVersion.Latest, false),
                                    new("/v2/characters/{character_id}/skillqueue/", EndpointVersion.V2, true),
                                    new("/legacy/characters/{character_id}/skillqueue/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/skillqueue/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Skills.SkillDetails, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-skills.read_skills.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/skills/", EndpointVersion.Latest, false),
                                    new("/v4/characters/{character_id}/skills/", EndpointVersion.V4, true),
                                    new("/dev/characters/{character_id}/skills/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Sovereignty
                        {
                            ESI.Endpoints.Sovereignty.Campaigns, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/sovereignty/campaigns/", EndpointVersion.Latest, false),
                                    new("/v1/sovereignty/campaigns/", EndpointVersion.V1, true),
                                    new("/legacy/sovereignty/campaigns/", EndpointVersion.Legacy, false),
                                    new("/dev/sovereignty/campaigns/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Sovereignty.SolarSystems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/sovereignty/map/", EndpointVersion.Latest, false),
                                    new("/v1/sovereignty/map/", EndpointVersion.V1, true),
                                    new("/legacy/sovereignty/map/", EndpointVersion.Legacy, false),
                                    new("/dev/sovereignty/map/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Sovereignty.Structures, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/sovereignty/structures/", EndpointVersion.Latest, false),
                                    new("/v1/sovereignty/structures/", EndpointVersion.V1, true),
                                    new("/legacy/sovereignty/structures/", EndpointVersion.Legacy, false),
                                    new("/dev/sovereignty/structures/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Status
                        {
                            ESI.Endpoints.Status.ServerStatus, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/status/", EndpointVersion.Latest, false),
                                    new("/v1/status/", EndpointVersion.V1, true),
                                    new("/v2/status/", EndpointVersion.V2, true),
                                    new("/legacy/status/", EndpointVersion.Legacy, false),
                                    new("/dev/status/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Universe
                        {
                            ESI.Endpoints.Universe.Ancestries, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/ancestries/", EndpointVersion.Latest, false),
                                    new("/v1/universe/ancestries/", EndpointVersion.V1, true),
                                    new("/legacy/universe/ancestries/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.AsteroidBeltInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/asteroid_belts/{asteroid_belt_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/asteroid_belts/{asteroid_belt_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/asteroid_belts/{asteroid_belt_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Bloodlines, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/bloodlines/", EndpointVersion.Latest, false),
                                    new("/v1/universe/bloodlines/", EndpointVersion.V1, true),
                                    new("/legacy/universe/bloodlines/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.ItemCategories, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/categories/", EndpointVersion.Latest, false),
                                    new("/v1/universe/categories/", EndpointVersion.V1, true),
                                    new("/legacy/universe/categories/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.ItemCategoryInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/categories/{category_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/categories/{category_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/categories/{category_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Constellations, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/constellations/", EndpointVersion.Latest, false),
                                    new("/v1/universe/constellations/", EndpointVersion.V1, true),
                                    new("/legacy/universe/constellations/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.ConstellationInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/constellations/{constellation_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/constellations/{constellation_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/constellations/{constellation_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Factions, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/factions/", EndpointVersion.Latest, false),
                                    new("/v2/universe/factions/", EndpointVersion.V2, true),
                                    new("/dev/universe/factions/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Graphics, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/graphics/", EndpointVersion.Latest, false),
                                    new("/v1/universe/graphics/", EndpointVersion.V1, true),
                                    new("/legacy/universe/graphics/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.GraphicInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/graphics/{graphic_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/graphics/{graphic_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/graphics/{graphic_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/graphics/{graphic_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.ItemGroups, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/groups/", EndpointVersion.Latest, false),
                                    new("/v1/universe/groups/", EndpointVersion.V1, true),
                                    new("/legacy/universe/groups/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.ItemGroupInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/groups/{group_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/groups/{group_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/groups/{group_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/groups/{group_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.IDs, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/ids/", EndpointVersion.Latest, false),
                                    new("/v1/universe/ids/", EndpointVersion.V1, true),
                                    new("/legacy/universe/ids/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/ids/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Names, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/names/", EndpointVersion.Latest, false),
                                    new("/v3/universe/names/", EndpointVersion.V3, true),
                                    new("/dev/universe/names/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.PlanetInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/planets/{planet_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/planets/{planet_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/planets/{planet_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Races, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/races/", EndpointVersion.Latest, false),
                                    new("/v1/universe/races/", EndpointVersion.V1, true),
                                    new("/legacy/universe/races/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/races/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Regions, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/regions/", EndpointVersion.Latest, false),
                                    new("/v1/universe/regions/", EndpointVersion.V1, true),
                                    new("/legacy/universe/regions/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.RegionInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/regions/{region_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/regions/{region_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/regions/{region_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.StargateInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/stargates/{stargate_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/stargates/{stargate_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/stargates/{stargate_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.StarInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/stars/{star_id}/", EndpointVersion.Latest, false),
                                    new("/v1/universe/stars/{star_id}/", EndpointVersion.V1, true),
                                    new("/legacy/universe/stars/{star_id}/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.StationInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/stations/{station_id}/", EndpointVersion.Latest, false),
                                    new("/v2/universe/stations/{station_id}/", EndpointVersion.V2, true),
                                    new("/dev/universe/stations/{station_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Structures, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/structures/", EndpointVersion.Latest, false),
                                    new("/v1/universe/structures/", EndpointVersion.V1, true),
                                    new("/legacy/universe/structures/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/structures/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.StructureInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-universe.read_structures.v1";
                                builder.Routes =
                                [
                                    new("/latest/universe/structures/{structure_id}/", EndpointVersion.Latest, false),
                                    new("/v2/universe/structures/{structure_id}/", EndpointVersion.V2, true)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.SystemJumps, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/system_jumps/", EndpointVersion.Latest, false),
                                    new("/v1/universe/system_jumps/", EndpointVersion.V1, true),
                                    new("/legacy/universe/system_jumps/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.SystemKills, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/system_kills/", EndpointVersion.Latest, false),
                                    new("/v2/universe/system_kills/", EndpointVersion.V2, true)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.SolarSystems, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/systems/", EndpointVersion.Latest, false),
                                    new("/v1/universe/systems/", EndpointVersion.V1, true),
                                    new("/legacy/universe/systems/", EndpointVersion.Legacy, false),
                                    new("/dev/universe/systems/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.SolarSystemInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/systems/{system_id}/", EndpointVersion.Latest, false),
                                    new("/v4/universe/systems/{system_id}/", EndpointVersion.V4, true),
                                    new("/dev/universe/systems/{system_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.Types, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/types/", EndpointVersion.Latest, false),
                                    new("/v1/universe/types/", EndpointVersion.V1, true),
                                    new("/legacy/universe/types/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Universe.TypeInfo, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/universe/types/{type_id}/", EndpointVersion.Latest, false),
                                    new("/v3/universe/types/{type_id}/", EndpointVersion.V3, true),
                                    new("/dev/universe/types/{type_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region UserInterface
                        {
                            ESI.Endpoints.UserInterface.SetAutopilotWaypoint, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-ui.write_waypoint.v1";
                                builder.Routes =
                                [
                                    new("/latest/ui/autopilot/waypoint/", EndpointVersion.Latest, false),
                                    new("/v2/ui/autopilot/waypoint/", EndpointVersion.V2, true),
                                    new("/legacy/ui/autopilot/waypoint/", EndpointVersion.Legacy, false),
                                    new("/dev/ui/autopilot/waypoint/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.UserInterface.OpenContractWindow, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-ui.open_window.v1";
                                builder.Routes =
                                [
                                    new("/latest/ui/openwindow/contract/", EndpointVersion.Latest, false),
                                    new("/v1/ui/openwindow/contract/", EndpointVersion.V1, true),
                                    new("/legacy/ui/openwindow/contract/", EndpointVersion.Legacy, false),
                                    new("/dev/ui/openwindow/contract/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.UserInterface.OpenInformationWindow, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-ui.open_window.v1";
                                builder.Routes =
                                [
                                    new("/latest/ui/openwindow/information/", EndpointVersion.Latest, false),
                                    new("/v1/ui/openwindow/information/", EndpointVersion.V1, true),
                                    new("/legacy/ui/openwindow/information/", EndpointVersion.Legacy, false),
                                    new("/dev/ui/openwindow/information/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.UserInterface.OpenMarketDetails, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-ui.open_window.v1";
                                builder.Routes =
                                [
                                    new("/latest/ui/openwindow/marketdetails/", EndpointVersion.Latest, false),
                                    new("/v1/ui/openwindow/marketdetails/", EndpointVersion.V1, true),
                                    new("/legacy/ui/openwindow/marketdetails/", EndpointVersion.Legacy, false),
                                    new("/dev/ui/openwindow/marketdetails/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.UserInterface.OpenNewMailWindow, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Post;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-ui.open_window.v1";
                                builder.Routes =
                                [
                                    new("/latest/ui/openwindow/newmail/", EndpointVersion.Latest, false),
                                    new("/v1/ui/openwindow/newmail/", EndpointVersion.V1, true),
                                    new("/legacy/ui/openwindow/newmail/", EndpointVersion.Legacy, false),
                                    new("/dev/ui/openwindow/newmail/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Wallet
                        {
                            ESI.Endpoints.Wallet.WalletBalance, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_character_wallet.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/wallet/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/wallet/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/wallet/", EndpointVersion.Legacy, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wallet.WalletJournal, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_character_wallet.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/wallet/journal/", EndpointVersion.Latest, false),
                                    new("/v6/characters/{character_id}/wallet/journal/", EndpointVersion.V6, true),
                                    new("/dev/characters/{character_id}/wallet/journal/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wallet.WalletTransactions, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_character_wallet.v1";
                                builder.Routes =
                                [
                                    new("/latest/characters/{character_id}/wallet/transactions/", EndpointVersion.Latest, false),
                                    new("/v1/characters/{character_id}/wallet/transactions/", EndpointVersion.V1, true),
                                    new("/legacy/characters/{character_id}/wallet/transactions/", EndpointVersion.Legacy, false),
                                    new("/dev/characters/{character_id}/wallet/transactions/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wallet.CorporationWallets, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_corporation_wallets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/wallets/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/wallets/", EndpointVersion.V1, true),
                                    new("/legacy/corporations/{corporation_id}/wallets/", EndpointVersion.Legacy, false),
                                    new("/dev/corporations/{corporation_id}/wallets/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wallet.CorporationWalletJournal, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_corporation_wallets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/wallets/{division}/journal/", EndpointVersion.Latest, false),
                                    new("/v4/corporations/{corporation_id}/wallets/{division}/journal/", EndpointVersion.V4, true),
                                    new("/dev/corporations/{corporation_id}/wallets/{division}/journal/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wallet.CorporationWalletTransactions, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = true;
                                builder.Scope = "esi-wallet.read_corporation_wallets.v1";
                                builder.Routes =
                                [
                                    new("/latest/corporations/{corporation_id}/wallets/{division}/transactions/", EndpointVersion.Latest, false),
                                    new("/v1/corporations/{corporation_id}/wallets/{division}/transactions/", EndpointVersion.V1, true),
                                    new("/legacy/corporations/{corporation_id}/wallets/{division}/transactions/", EndpointVersion.Legacy, false),
                                    new("/dev/corporations/{corporation_id}/wallets/{division}/transactions/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        #endregion

                        #region Wars
                        {
                            ESI.Endpoints.Wars.WarList, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/wars/", EndpointVersion.Latest, false),
                                    new("/v1/wars/", EndpointVersion.V1, true),
                                    new("/legacy/wars/", EndpointVersion.Legacy, false),
                                    new("/dev/wars/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wars.WarDetails, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/wars/{war_id}/", EndpointVersion.Latest, false),
                                    new("/v1/wars/{war_id}/", EndpointVersion.V1, true),
                                    new("/legacy/wars/{war_id}/", EndpointVersion.Legacy, false),
                                    new("/dev/wars/{war_id}/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                        {
                            ESI.Endpoints.Wars.Kills, builder =>
                            {
                                builder.HttpMethodType = HttpMethodType.Get;
                                builder.ProtectedEndpoint = false;
                                builder.Routes =
                                [
                                    new("/latest/wars/{war_id}/killmails/", EndpointVersion.Latest, false),
                                    new("/v1/wars/{war_id}/killmails/", EndpointVersion.V1, true),
                                    new("/legacy/wars/{war_id}/killmails/", EndpointVersion.Legacy, false),
                                    new("/dev/wars/{war_id}/killmails/", EndpointVersion.Dev, false)
                                ];
                            }
                        },
                            #endregion
                    };
            }
        }

        internal static class KnownHeaders
        {
            public const string ETag = "ETag";
        }

        public static class Parameters
        {
            public static class Route
            {
                public const string CharacterId = "character_id";
                public const string AllianceId = "alliance_id";
                public const string CorporationId = "corporation_id";
                public const string EventId = "event_id";
                public const string ContractId = "contract_id";
                public const string RegionId = "region_id";
                public const string StarbaseId = "starbase_id";
                public const string AttributeId = "attribute_id";
                public const string EffectId = "effect_id";
                public const string TypeId = "type_id";
                public const string ItemId = "item_id";
                public const string FittingId = "fitting_id";
                public const string FleetId = "fleet_id";
                public const string MemberId = "member_id";
                public const string SquadId = "squad_id";
                public const string WingId = "wing_id";
                public const string KillmailId = "killmail_id";
                public const string KillmainHash = "killmail_hash ";
                public const string MailId = "mail_id";
                public const string LabelId = "label_id";
                public const string MarketGroupId = "market_group_id";
                public const string StructureId = "structure_id";
                public const string PlanetId = "planet_id";
                public const string SchematicId = "schematic_id";
                public const string RouteDestination = "destination";
                public const string RouteOrigin = "origin";
                public const string AsteroidBeltId = "asteroid_belt_id";
                public const string ConstellationId = "constellation_id";
                public const string GraphicId = "graphic_id";
                public const string ItemCategoryId = "category_id";
                public const string ItemGroupId = "group_id";
                public const string MoonId = "moon_id";
                public const string SystemId = "system_id";
                public const string StargateId = "stargate_id";
                public const string StarId = "star_id";
                public const string StationId = "station_id";
                public const string Division = "division";
                public const string WarId = "war_id";
            }

            public static class Query
            {
                public const string Datasource = "datasource";
                public const string Page = "page";
                public const string FromEvent = "from_event";
                public const string Standing = "standing";
                public const string Watched = "watched";
                public const string LableIds = "label_ids";
                public const string ContactIds = "contact_ids";
                public const string SystemId = "system_id";
                public const string IncludeCompleted = "include_completed";
                public const string ObserverId = "observer_id";
                public const string LastMailId = "last_mail_id";
                public const string Labels = "labels";
                public const string RegionTypeId = "type_id";
                public const string RegionOrderType = "order_type";
                public const string RouteFlag = "flag";
                public const string AvoidSolarSystems = "avoid";
                public const string SolarSystemsConnections = "connections";
                public const string Search = "search";
                public const string SearchCategories = "categories";
                public const string SearchStrict = "strict";
                public const string StructuresFilter = "filter";
                public const string ContractId = "contract_id";
                public const string TargetId = "target_id";
                public const string ItemTypeId = "type_id";
                public const string WaypointDestinationId = "destination_id";
                public const string WaypointAddToBeginning = "add_to_beginning";
                public const string WaypointClearOtherWaypoints = "clear_other_waypoints";
                public const string FromId = "from_id";
                public const string MaxWarId = "max_war_id";
            }
        }
    }
}
