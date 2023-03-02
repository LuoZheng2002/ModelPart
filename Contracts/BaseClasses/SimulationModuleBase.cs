using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class SimulationModuleBase:ExecutableBase
	{
		public ExecutableBase ConnectedToPlayer1Wins { get; set; }
		public ExecutableBase ConnectedToPlayer2Wins { get; set; }
		public Solution Player1Solution { get; set; }
		public Solution Player2Solution { get; set; }

	}
}
