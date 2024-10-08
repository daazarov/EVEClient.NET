﻿namespace EVEClient.NET
{
    /// <summary>
    /// Defines a class which provide facade to access specific parts of the ESI API.
    /// </summary>
    public interface IEsiLogicAccessor
    {
        ICharacterLogic CharacterLogic { get; }
        IAllianceLogic AllianceLogic { get; }
        IAssetsLogic AssetsLogic { get; }
        IBookmarksLogic BookmarksLogic { get; }
        ICalendarLogic CalendarLogic { get; }
        IClonesLogic ClonesLogic { get; }
        IContactsLogic ContactsLogic { get; }
        IContractsLogic ContractsLogic { get; }
        ICorporationLogic CorporationLogic { get; }
        IDogmaLogic DogmaLogic { get; }
        IFactionWarfareLogic FactionWarfareLogic { get; }
        IFittingsLogic FittingsLogic { get; }
        IFleetsLogic FleetsLogic { get; }
        IIncursionsLogic IncursionsLogic { get; }
        IIndustryLogic IndustryLogic { get; }
        IInsuranceLogic InsuranceLogic { get; }
        IKillmailsLogic KillmailsLogic { get; }
        ILocationLogic LocationLogic { get; }
        ILoyaltyLogic LoyaltyLogic { get; }
        IMailLogic MailLogic { get; }
        IMarketLogic MarketLogic { get; }
        IOpportunitiesLogic OpportunitiesLogic { get; }
        IPlanetaryInteractionLogic PlanetaryInteractionLogic { get; }
        IRoutesLogic RoutesLogic { get; }
        ISearchLogic SearchLogic { get; }
        ISkillsLogic SkillsLogic { get; }
        IUniverseLogic UniverseLogic { get; }
        IWalletLogic WalletLogic { get; }
        IUserInterfaceLogic UserInterfaceLogic { get; }
        IWarsLogic WarsLogic { get; }
    }
}
