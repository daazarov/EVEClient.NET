namespace EVEClient.NET
{
    internal class EsiLogicAccessor : IEsiLogicAccessor
    {
        private readonly ICharacterLogic _characterLogic;
        private readonly IAllianceLogic _allianceLogic;
        private readonly IAssetsLogic _assetsLogic;
        private readonly IBookmarksLogic _bookmarksLogic;
        private readonly ICalendarLogic _calendarLogic;
        private readonly IClonesLogic _clonesLogic;
        private readonly IContactsLogic _contactsLogic;
        private readonly IContractsLogic _contractsLogic;
        private readonly ICorporationLogic _corporationLogic;
        private readonly IDogmaLogic _dogmaLogic;
        private readonly IFactionWarfareLogic _factionWarfareLogic;
        private readonly IFittingsLogic _fittingsLogic;
        private readonly IFleetsLogic _fleetsLogic;
        private readonly IIncursionsLogic _incursionsLogic;
        private readonly IIndustryLogic _industryLogic;
        private readonly IInsuranceLogic _insuranceLogic;
        private readonly IKillmailsLogic _killmailsLogic;
        private readonly ILocationLogic _locationLogic;
        private readonly ILoyaltyLogic _loyaltyLogic;
        private readonly IMailLogic _mailLogic;
        private readonly IMarketLogic _marketLogic;
        private readonly IOpportunitiesLogic _opportunitiesLogic;
        private readonly IPlanetaryInteractionLogic _planetaryInteractionLogic;
        private readonly IRoutesLogic _routesLogic;
        private readonly ISearchLogic _searchLogic;
        private readonly ISkillsLogic _skillsLogic;
        private readonly IUniverseLogic _universeLogic;
        private readonly IUserInterfaceLogic _userInterfaceLogic;
        private readonly IWalletLogic _walletLogic;
        private readonly IWarsLogic _warsLogic;

        public EsiLogicAccessor(
            ICharacterLogic characterLogic,
            IAllianceLogic allianceLogic,
            IAssetsLogic assetsLogic,
            IBookmarksLogic bookmarksLogic,
            ICalendarLogic calendarLogic,
            IClonesLogic clonesLogic,
            IContactsLogic contactsLogic,
            IContractsLogic contractsLogic,
            ICorporationLogic corporationLogic,
            IDogmaLogic dogmaLogic,
            IFactionWarfareLogic factionWarfareLogic,
            IFittingsLogic fittingsLogic,
            IFleetsLogic fleetsLogic,
            IIncursionsLogic incursionsLogic,
            IIndustryLogic industryLogic,
            IInsuranceLogic insuranceLogic,
            IKillmailsLogic killmailsLogic,
            ILocationLogic locationLogic,
            ILoyaltyLogic loyaltyLogic,
            IMailLogic mailLogic,
            IMarketLogic marketLogic,
            IOpportunitiesLogic opportunitiesLogic,
            IPlanetaryInteractionLogic planetaryInteractionLogic,
            IRoutesLogic routesLogic,
            ISearchLogic searchLogic,
            ISkillsLogic skillsLogic,
            IUniverseLogic universeLogic,
            IUserInterfaceLogic userInterfaceLogic,
            IWalletLogic walletLogic,
            IWarsLogic warsLogic)
        {
            _characterLogic = characterLogic;
            _allianceLogic = allianceLogic;
            _assetsLogic = assetsLogic;
            _bookmarksLogic = bookmarksLogic;
            _calendarLogic = calendarLogic;
            _clonesLogic = clonesLogic;
            _contactsLogic = contactsLogic;
            _contractsLogic = contractsLogic;
            _corporationLogic = corporationLogic;
            _dogmaLogic = dogmaLogic;
            _factionWarfareLogic = factionWarfareLogic;
            _fittingsLogic = fittingsLogic;
            _fleetsLogic = fleetsLogic;
            _incursionsLogic = incursionsLogic;
            _industryLogic = industryLogic;
            _insuranceLogic = insuranceLogic;
            _killmailsLogic = killmailsLogic;
            _locationLogic = locationLogic;
            _loyaltyLogic = loyaltyLogic;
            _mailLogic = mailLogic;
            _marketLogic = marketLogic;
            _opportunitiesLogic = opportunitiesLogic;
            _planetaryInteractionLogic = planetaryInteractionLogic;
            _routesLogic = routesLogic;
            _searchLogic = searchLogic;
            _skillsLogic = skillsLogic;
            _universeLogic = universeLogic;
            _userInterfaceLogic = userInterfaceLogic;
            _walletLogic = walletLogic;
            _warsLogic = warsLogic;
    }

        public ICharacterLogic CharacterLogic => _characterLogic;
        public IAllianceLogic AllianceLogic => _allianceLogic;
        public IAssetsLogic AssetsLogic => _assetsLogic;
        public IBookmarksLogic BookmarksLogic => _bookmarksLogic;
        public ICalendarLogic CalendarLogic => _calendarLogic;
        public IClonesLogic ClonesLogic => _clonesLogic;
        public IContactsLogic ContactsLogic => _contactsLogic;
        public IContractsLogic ContractsLogic => _contractsLogic;
        public ICorporationLogic CorporationLogic => _corporationLogic;
        public IDogmaLogic DogmaLogic => _dogmaLogic;
        public IFactionWarfareLogic FactionWarfareLogic => _factionWarfareLogic;
        public IFittingsLogic FittingsLogic => _fittingsLogic;
        public IFleetsLogic FleetsLogic => _fleetsLogic;
        public IIncursionsLogic IncursionsLogic => _incursionsLogic;
        public IIndustryLogic IndustryLogic => _industryLogic;
        public IInsuranceLogic InsuranceLogic => _insuranceLogic;
        public IKillmailsLogic KillmailsLogic => _killmailsLogic;
        public ILocationLogic LocationLogic => _locationLogic;
        public ILoyaltyLogic LoyaltyLogic => _loyaltyLogic;
        public IMailLogic MailLogic => _mailLogic;
        public IMarketLogic MarketLogic => _marketLogic;
        public IOpportunitiesLogic OpportunitiesLogic => _opportunitiesLogic;
        public IPlanetaryInteractionLogic PlanetaryInteractionLogic => _planetaryInteractionLogic;
        public IRoutesLogic RoutesLogic => _routesLogic;
        public ISearchLogic SearchLogic => _searchLogic;
        public ISkillsLogic SkillsLogic => _skillsLogic;
        public IUniverseLogic UniverseLogic => _universeLogic;
        public IUserInterfaceLogic UserInterfaceLogic => _userInterfaceLogic;
        public IWalletLogic WalletLogic => _walletLogic;
        public IWarsLogic WarsLogic => _warsLogic;
    }
}
