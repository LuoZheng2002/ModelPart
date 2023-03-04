using Contracts.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
	public class ProjectSolution:ExecutableBase
	{
		public List<Solution> Solutions { get; set; } = new();
		public Solution MainSolution { get; set; } = new();
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			return MainSolution.ExecuteModule(gameModel, arg);
		}
        public ProjectSolution()
        {
            
        }
    }
}
