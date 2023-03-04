using Contracts.BaseClasses;
using Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
	public class StrategySet:ExecutableBase
	{
		private MoveInfo ExecuteParallel(GameModelBase gameModel, ArgBase? arg)
		{
			List<MoveInfo> results = new();
			foreach (var strategy in Strategies)
			{
				MoveInfo moveInfo = strategy.ExecuteModule(gameModel, arg);
				results.Add(moveInfo);
			}
			MoveInfo? result;
			if (results.Count > 0)
			{
				result = results.MaxBy(moveInfo => moveInfo.Rating);
			}
			else
			{
				result = MoveInfo.Failed;
			}
			return result!;
		}
		private MoveInfo ExecuteHierarchical(GameModelBase gameModel, ArgBase? arg)
		{
			foreach (var strategy in Strategies)
			{
				MoveInfo moveInfo = strategy.ExecuteModule(gameModel, arg);
				if (moveInfo.Succeeded)
				{
					return moveInfo;
				}
			}
			return MoveInfo.Failed;
		}
		public StrategySetType Type { get; set; }
		public List<StrategyBase> Strategies { get; set; } = new();
		public void AddStrategy(StrategyBase strategy)
		{
			Strategies.Add(strategy);
		}
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			if (Type==StrategySetType.Parallel)
			{
				return ExecuteParallel(gameModel, arg);
			}
			else
			{
				return ExecuteHierarchical(gameModel, arg);
			}
		}
	}
}
