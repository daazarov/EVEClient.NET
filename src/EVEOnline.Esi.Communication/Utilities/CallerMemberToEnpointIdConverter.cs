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
                { "GetCharacterPulicInformationAsync", "get_characters_character_id" },
                { "GetCharacterStandingsAsync", "get_characters_character_id_standings" },
                { "GetCharacterAgentsResearchAsync", "get_characters_character_id_agents_research" },
                { "GetCharacterBlueprintsAsync", "get_characters_character_id_blueprints" },
                { "GetCharacterCorporationHistoryAsync", "get_characters_character_id_corporationhistory" },
                { "PostCharacterCspaAsync", "post_characters_character_id_cspa" },
                { "GetCharacterFatigueAsync", "get_characters_character_id_fatigue" },
                { "GetCharacterMedalsAsync", "get_characters_character_id_medals" },
                { "GetCharacterNotificationsAsync", "get_characters_character_id_notifications" },
                { "GetCharacterContactNotificationsAsync", "get_characters_character_id_notifications_contacts" },
                { "GetCharacterPortraitAsync", "get_characters_character_id_portrait" },
                { "GetCharacterRolesAsync", "get_characters_character_id_roles" },
                { "GetCharacterTitlesAsync", "get_characters_character_id_titles" },
                { "PostCharacterAffilationAsync", "post_characters_affiliation" },

                { "GetAlliancesAsync", "get_alliance" },
                { "GetAlliancePublicInformationAsync", "get_alliances_alliance_id" },
                { "GetAllianceCorporationsAsync", "get_alliances_alliance_id_corporations" },
                { "GetAllianceIconAsync", "get_alliances_alliance_id_icons" },

                { "GetCharacterAssets", "get_characters_character_id_assets" },
                { "PostCharacterLocationAssets", "post_characters_character_id_assets_locations"},
                { "PostCharacterNameAssets", "post_characters_character_id_assets_names" },
                { "GetCorporationAssets", "get_corporations_corporation_id_assets" },
                { "PostCorporationLocationAssets", "post_corporations_corporation_id_assets_locations" },
                { "PostCorporationNameAssets", "post_corporations_corporation_id_assets_names" }
            };
        }

        public static string ToEndpointId(string callerMember)
        { 
            return _dataset[callerMember];
        }
    }
}
