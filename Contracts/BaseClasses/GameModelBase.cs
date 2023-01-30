using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
    public abstract class GameModelBase
    {
        public int WhoseTurn { get; set; }
        public int WhoIsAI { get; set; }
        public abstract bool ValidMove(MoveBase move);
        public abstract void DoMove(MoveBase move);
    }
}
