namespace EVEOnline.Esi.Communication
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
    }
}
