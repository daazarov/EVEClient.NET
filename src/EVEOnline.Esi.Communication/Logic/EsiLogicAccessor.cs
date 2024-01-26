using System;
using Microsoft.Extensions.DependencyInjection;
using EVEOnline.Esi.Communication.Logic.Interfaces;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class EsiLogicAccessor : IEsiLogicAccessor
    {
        private readonly IServiceProvider _serviceProvider;

        private ICharacterLogic _characterLogic;
        private IAllianceLogic _allianceLogic;
        private IAssetsLogic _assetsLogic;
        private IBookmarksLogic _bookmarksLogic;
        private ICalendarLogic _calendarLogic;
        private IClonesLogic _clonesLogic;
        private IContactsLogic _contactsLogic;

        public ICharacterLogic CharacterLogic => GetOrSet<ICharacterLogic>(ref _characterLogic);
        public IAllianceLogic AllianceLogic => GetOrSet<IAllianceLogic>(ref _allianceLogic);
        public IAssetsLogic AssetsLogic => GetOrSet<IAssetsLogic>(ref _assetsLogic);
        public IBookmarksLogic BookmarksLogic => GetOrSet<IBookmarksLogic>(ref _bookmarksLogic);
        public ICalendarLogic CalendarLogic => GetOrSet<ICalendarLogic>(ref _calendarLogic);
        public IClonesLogic ClonesLogic => GetOrSet<IClonesLogic>(ref _clonesLogic);
        public IContactsLogic ContactsLogic => GetOrSet<IContactsLogic>(ref _contactsLogic);


        public EsiLogicAccessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private T GetOrSet<T>(ref T instance) => instance ?? (instance = _serviceProvider.GetRequiredService<T>());
    }
}
