using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class SolutionModel:IDiagramElementModel
	{
		public string SolutionName { get; set; }
		public string TargetSolutionClassName { get; set; }
		public StrategySetModel? Entry { get; set; }
		public List<IDiagramElementModel> SolutionItems { get; set; } = new();
		public SolutionModel(string solutionName, string targetSolutionClassName)
		{
			SolutionName = solutionName;
			TargetSolutionClassName = targetSolutionClassName;
		}
	}
}
