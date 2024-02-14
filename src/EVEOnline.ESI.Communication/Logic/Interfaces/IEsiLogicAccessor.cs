namespace EVEOnline.ESI.Communication
{
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
    }
}
