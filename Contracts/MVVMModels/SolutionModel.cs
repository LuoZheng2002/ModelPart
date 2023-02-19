using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	[Serializable]
	public class SolutionModel:IDiagramElementModel
	{
		public string SolutionName { get; set; } = "";
		public string SolutionFileName
		{
			get { return SolutionName + ".smsln"; }
		}
		public StrategySetModel? Entry { get; set; }
		public List<IDiagramElementModel> SolutionItems { get; set; } = new();
		public SolutionModel(string solutionName)
		{
			SolutionName = solutionName;
		}
		public SolutionModel() { }
	}
}
