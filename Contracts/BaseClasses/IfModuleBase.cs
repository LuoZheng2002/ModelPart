using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class IfModuleBase: ExecutableBase
	{
		public ExecutableBase ConnectedToTrue { get; set; }
		public ExecutableBase ConnectedToFalse { get; set; }
		public abstract bool JudgeStatement(GameModelBase gameModel);
		public override MoveInfo Execute(GameModelBase gameModel)
		{
			MoveInfo moveInfo;
			if (JudgeStatement(gameModel))
			{
				moveInfo = ConnectedToTrue.Execute(gameModel);
			}
			else
			{
				moveInfo = ConnectedToFalse.Execute(gameModel);
			}
			return moveInfo;
		}
	}
}
