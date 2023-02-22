using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class SolutionModel
	{
		public string SolutionName { get; set; } = "";
		public string SolutionFileName
		{
			get { return SolutionName + ".smsln"; }
		}
		public List<DiagramElementModel> DiagramItemModels { get; set; } = new();
		public SolutionModel(string solutionName)
		{
			SolutionName = solutionName;
		}
		public SolutionModel() { }
		public void OnDiagramItemDestroy(DiagramElementModel model)
		{
			DiagramItemModels.Remove(model);
		}
	}
}
