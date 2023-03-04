using Contracts.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
	public interface IJudgeable
	{
		public bool Judge(GameModelBase gameModel, ArgBase? arg, out ArgBase judgeArg);
	}
}
