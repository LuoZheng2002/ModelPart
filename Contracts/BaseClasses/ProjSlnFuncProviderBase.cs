using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class ProjSlnFuncProviderBase
	{
		public abstract ProjectSolution ProjectSolution { get; }
		public MoveInfo Execute(GameModelBase gameModel)
		{
			MoveInfo moveInfo = ProjectSolution.MainSolution.ExecuteModule(gameModel, null);
			return moveInfo;
		}
	}
}
