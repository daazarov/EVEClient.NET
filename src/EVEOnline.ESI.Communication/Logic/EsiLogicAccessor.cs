﻿using System;
using Microsoft.Extensions.DependencyInjection;

namespace EVEOnline.ESI.Communication.Logic
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
        private IContractsLogic _contractsLogic;
        private ICorporationLogic _corporationLogic;
        private IDogmaLogic _dogmaLogic;
        private IFactionWarfareLogic _factionWarfareLogic;
        private IFittingsLogic _fittingsLogic;
        private IFleetsLogic _fleetsLogic;
        private IIncursionsLogic _incursionsLogic;
        private IIndustryLogic _industryLogic;
        private IInsuranceLogic _insuranceLogic;
        private IKillmailsLogic _killmailsLogic;
        private ILocationLogic _locationLogic;

        public ICharacterLogic CharacterLogic => GetOrSet<ICharacterLogic>(ref _characterLogic);
        public IAllianceLogic AllianceLogic => GetOrSet<IAllianceLogic>(ref _allianceLogic);
        public IAssetsLogic AssetsLogic => GetOrSet<IAssetsLogic>(ref _assetsLogic);
        public IBookmarksLogic BookmarksLogic => GetOrSet<IBookmarksLogic>(ref _bookmarksLogic);
        public ICalendarLogic CalendarLogic => GetOrSet<ICalendarLogic>(ref _calendarLogic);
        public IClonesLogic ClonesLogic => GetOrSet<IClonesLogic>(ref _clonesLogic);
        public IContactsLogic ContactsLogic => GetOrSet<IContactsLogic>(ref _contactsLogic);
        public IContractsLogic ContractsLogic => GetOrSet<IContractsLogic>(ref _contractsLogic);
        public ICorporationLogic CorporationLogic => GetOrSet<ICorporationLogic>(ref _corporationLogic);
        public IDogmaLogic DogmaLogic => GetOrSet<IDogmaLogic>(ref _dogmaLogic);
        public IFactionWarfareLogic FactionWarfareLogic => GetOrSet<IFactionWarfareLogic>(ref _factionWarfareLogic);
        public IFittingsLogic FittingsLogic => GetOrSet<IFittingsLogic>(ref _fittingsLogic);
        public IFleetsLogic FleetsLogic => GetOrSet<IFleetsLogic>(ref _fleetsLogic);
        public IIncursionsLogic IncursionsLogic => GetOrSet<IIncursionsLogic>(ref _incursionsLogic);
        public IIndustryLogic IndustryLogic => GetOrSet<IIndustryLogic>(ref _industryLogic);
        public IInsuranceLogic InsuranceLogic => GetOrSet<IInsuranceLogic>(ref _insuranceLogic);
        public IKillmailsLogic KillmailsLogic => GetOrSet<IKillmailsLogic>(ref _killmailsLogic);
        public ILocationLogic LocationLogic => GetOrSet<ILocationLogic>(ref _locationLogic);

        public EsiLogicAccessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private T GetOrSet<T>(ref T instance) => instance ?? (instance = _serviceProvider.GetRequiredService<T>());
    }
}
