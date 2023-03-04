using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class SwitchModuleBase: ExecutableBase
	{
		public abstract Dictionary<string, Func<GameModelBase, bool>> Cases { get;}
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public Dictionary<string, ExecutableBase> Connections { get; set; } = new();
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			MoveInfo moveInfo;
			foreach (var c in Connections)
			{
				bool gotValue = Cases.TryGetValue(c.Key, out Func<GameModelBase, bool>? func);
				if (!gotValue)
				{
					throw new Exception("Something went wrong in SwitchModuleBase.");
				}
				bool success = func!(gameModel);
				if (success)
				{
					moveInfo = c.Value.ExecuteModule(gameModel, arg);
					return moveInfo;
				}
			}
			return MoveInfo.Failed;
		}
	}
}
