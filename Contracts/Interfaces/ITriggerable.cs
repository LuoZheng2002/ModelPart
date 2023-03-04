using Contracts.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
    public interface ITriggerable
    {
        public void Trigger(GameModelBase gameModel, ArgBase? arg, out List<ArgBase> triggerArgs);
    }
}
