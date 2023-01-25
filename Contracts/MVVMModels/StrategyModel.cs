using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class StrategyModel
	{
		public string StrategyName { get; set; }
		public string StrategyClassName { get; set; }
		public IDiagramElementModel? LinkingTo { get; set; }
		public StrategyModel(string strategyName, string strategyClassName)
		{
			StrategyName = strategyName;
			StrategyClassName = strategyClassName;
		}
	}
}
