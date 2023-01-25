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
		public JudgeInfoBase Judge(GameModelBase gameModel, TriggerInfoBase? triggerInfo);
	}
}
