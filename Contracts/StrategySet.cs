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
		private MoveInfo ExecuteParallel(GameModelBase gameModel)
		{
			List<MoveInfo> results = new();
			foreach (var strategy in Strategies)
			{
				MoveInfo moveInfo = strategy.Execute(gameModel);
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
		private MoveInfo ExecuteHierarchical(GameModelBase gameModel)
		{
			foreach (var strategy in Strategies)
			{
				MoveInfo moveInfo = strategy.Execute(gameModel);
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
		public override MoveInfo Execute(GameModelBase gameModel)
		{
			if (Type==StrategySetType.Parallel)
			{
				return ExecuteParallel(gameModel);
			}
			else
			{
				return ExecuteHierarchical(gameModel);
			}
		}
	}
}
