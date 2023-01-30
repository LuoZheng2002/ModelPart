using Contracts.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
	public class Solution: ExecutableBase
	{
		public ExecutableBase StartExecutable { get; set; }
		public List<StrategySet> strategySets { get; set; }
		public List<IfModuleBase> IfModules { get; set; }
		public List<SwitchModuleBase> SwitchModules { get; set; }
		public List<SimulationModuleBase> SimulationModules { get; set; }
		public override MoveInfo Execute(GameModelBase gameModel)
		{
			return StartExecutable.Execute(gameModel);
		}
	}
}
