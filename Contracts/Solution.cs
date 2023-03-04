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
		public ExecutableBase? StartExecutable { get; set; }
		public List<StrategySet> StrategySets{ get; set; } = new();
		public List<IfModuleBase> IfModules { get; set; } = new();
		public List<SwitchModuleBase> SwitchModules { get; set; } = new();
		public List<SimulationModuleBase> SimulationModules { get; set; } = new();
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			return StartExecutable!.ExecuteModule(gameModel, arg);
		}
	}
}
