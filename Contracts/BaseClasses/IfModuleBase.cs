using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class IfModuleBase: ExecutableBase
	{
		public ExecutableBase? ConnectedToTrue { get; set; }
		public ExecutableBase? ConnectedToFalse { get; set; }
		public abstract bool JudgeStatement(GameModelBase gameModel);
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			MoveInfo moveInfo;
			if (JudgeStatement(gameModel))
			{
				moveInfo = ConnectedToTrue.ExecuteModule(gameModel, arg);
			}
			else
			{
				moveInfo = ConnectedToFalse.ExecuteModule(gameModel, arg);
			}
			return moveInfo;
		}
	}
}
