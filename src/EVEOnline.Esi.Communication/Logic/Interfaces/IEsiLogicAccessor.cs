using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEOnline.Esi.Communication.Logic.Interfaces
{
    public interface IEsiLogicAccessor
    {
        ICharacterLogic CharacterLogic { get; }
    }
}
