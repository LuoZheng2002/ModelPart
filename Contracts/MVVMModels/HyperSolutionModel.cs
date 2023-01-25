using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class HyperSolutionModel
	{
		public SolutionModel? MainSolutionModel { get; set; }
		public List<SolutionModel> Solutions { get; set; } = new();
	}
}
