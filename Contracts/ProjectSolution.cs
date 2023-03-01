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
		public List<Solution> solutions { get; set; } = new();
		public Solution MainSolution { get; set; } = new();
		public override MoveInfo Execute(GameModelBase gameModel)
		{
			return MainSolution.Execute(gameModel);
		}
        public ProjectSolution()
        {
            
        }
    }
}
