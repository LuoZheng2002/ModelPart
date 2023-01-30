using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class SwitchModuleBase: ExecutableBase
	{
		public Dictionary<Func<GameModelBase, bool>, ExecutableBase> CaseToConnection { get; set;}
		public override MoveInfo Execute(GameModelBase gameModel)
		{
			MoveInfo moveInfo;
			foreach (var c in CaseToConnection)
			{
				bool success = c.Key(gameModel);
				if (success)
				{
					moveInfo = c.Value.Execute(gameModel);
					return moveInfo;
				}
			}
			return MoveInfo.Failed;
		}
	}
}
