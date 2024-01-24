﻿using System;
using Microsoft.Extensions.DependencyInjection;
using EVEOnline.Esi.Communication.Logic.Interfaces;

namespace EVEOnline.Esi.Communication.Logic
{
    internal class EsiLogicAccessor : IEsiLogicAccessor
    {
        private readonly IServiceProvider _serviceProvider;

        private ICharacterLogic _characterLogic;
        private IAllianceLogic _allianceLogic;

        public ICharacterLogic CharacterLogic => GetOrSet<ICharacterLogic>(ref _characterLogic);
        public IAllianceLogic AllianceLogic => GetOrSet<IAllianceLogic>(ref _allianceLogic);


        public EsiLogicAccessor(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        private T GetOrSet<T>(ref T instance) => instance ?? (instance = _serviceProvider.GetRequiredService<T>());
    }
}
