using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class SimulationModuleBase:ExecutableBase
	{
		public ExecutableBase ConnectedToTrue { get; set; }
		public ExecutableBase ConnectedToFalse { get; set; }
		public Solution Player1AI { get; set; }
		public Solution Player2AI { get; set; }

	}
}
