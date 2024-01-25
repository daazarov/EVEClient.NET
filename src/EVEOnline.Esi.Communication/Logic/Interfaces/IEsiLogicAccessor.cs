﻿namespace EVEOnline.Esi.Communication.Logic.Interfaces
{
    public interface IEsiLogicAccessor
    {
        ICharacterLogic CharacterLogic { get; }
        IAllianceLogic AllianceLogic { get; }
        IAssetsLogic AssetsLogic { get; }
        IBookmarksLogic BookmarksLogic { get; }
    }
}
