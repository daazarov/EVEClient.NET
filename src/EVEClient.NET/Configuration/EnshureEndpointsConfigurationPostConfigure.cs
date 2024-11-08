using System;
using System.Collections.Generic;
using Microsoft.Extensions.Options;

namespace EVEClient.NET.Configuration
{
    internal class EnshureEndpointsConfigurationPostConfigure : IPostConfigureOptions<EsiClientConfiguration>
    {
        public void PostConfigure(string? name, EsiClientConfiguration options)
        {
            foreach (var kpv in DefaultConfiguration)
            {
                options.TryAddEndpointConfiguration(kpv.Key, kpv.Value);
            }
        }

        private static IDictionary<string, Action<EndpointConfigurationBuilder>> DefaultConfiguration =>
            new Dictionary<string, Action<EndpointConfigurationBuilder>>
            {
                #region Alliance
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

                #region Bookmarks
                {
                    ESI.Endpoints.Bookmarks.CharacterBookmarks, builder =>
                    {
                        builder.HttpMethodType = HttpMethodType.Get;
                        builder.ProtectedEndpoint = true;
                        builder.Scope = "esi-bookmarks.read_character_bookmarks.v1";
                        builder.Routes =
                        [
                            new("/latest/characters/{character_id}/bookmarks/", EndpointVersion.Latest, false),
                            new("/v2/characters/{character_id}/bookmarks/", EndpointVersion.V2, true),
                            new("/dev/characters/{character_id}/bookmarks/", EndpointVersion.Dev, false)
                        ];
                    }
                },
                {
                    ESI.Endpoints.Bookmarks.CharacterBookmarkFolders, builder =>
                    {
                        builder.HttpMethodType = HttpMethodType.Get;
                        builder.ProtectedEndpoint = true;
                        builder.Scope = "esi-bookmarks.read_character_bookmarks.v1";
                        builder.Routes =
                        [
                            new("latest/characters/{character_id}/bookmarks/folders/", EndpointVersion.Latest, false),
                            new("v2/characters/{character_id}/bookmarks/folders/", EndpointVersion.V2, true),
                            new("dev/characters/{character_id}/bookmarks/folders/", EndpointVersion.Dev, false)
                        ];
                    }
                },
                {
                    ESI.Endpoints.Bookmarks.CorporationBookmarks, builder =>
                    {
                        builder.HttpMethodType = HttpMethodType.Get;
                        builder.ProtectedEndpoint = true;
                        builder.Scope = "esi-bookmarks.read_corporation_bookmarks.v1";
                        builder.Routes =
                        [
                            new("/latest/corporations/{corporation_id}/bookmarks/", EndpointVersion.Latest, false),
                            new("/v1/corporations/{corporation_id}/bookmarks/", EndpointVersion.V1, true),
                            new("/dev/corporations/{corporation_id}/bookmarks/", EndpointVersion.Dev, false),
                            new("/legacy/corporations/{corporation_id}/bookmarks/", EndpointVersion.Legacy, false)
                        ];
                    }
                },
                {
                    ESI.Endpoints.Bookmarks.CorporationBookmarkFolders, builder =>
                    {
                        builder.HttpMethodType = HttpMethodType.Get;
                        builder.ProtectedEndpoint = true;
                        builder.Scope = "esi-bookmarks.read_corporation_bookmarks.v1";
                        builder.Routes =
                        [
                            new("/latest/corporations/{corporation_id}/bookmarks/folders/", EndpointVersion.Latest, false),
                            new("/v1/corporations/{corporation_id}/bookmarks/folders/", EndpointVersion.V1, true),
                            new("/dev/corporations/{corporation_id}/bookmarks/folders/", EndpointVersion.Dev, false),
                            new("/legacy/corporations/{corporation_id}/bookmarks/folders/", EndpointVersion.Legacy, false)
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
            };
    }
}
