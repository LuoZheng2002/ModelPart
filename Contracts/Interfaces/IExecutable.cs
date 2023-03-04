using Contracts.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.Interfaces
{
	public interface IExecutable
	{
		public MoveInfo Execute(GameModelBase gameModel, ArgBase? arg);
	}
}
