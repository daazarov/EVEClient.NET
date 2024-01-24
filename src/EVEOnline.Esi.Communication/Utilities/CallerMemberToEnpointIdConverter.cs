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
            };
        }

        public static string ToEndpointId(string callerMember)
        { 
            return _dataset[callerMember];
        }
    }
}
