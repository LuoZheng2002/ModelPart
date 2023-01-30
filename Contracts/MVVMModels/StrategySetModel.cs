using Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class StrategySetModel:IDiagramElementModel
	{
		public Point CanvasPos { get; set; }
		public string StrategySetName { get; set; }
		public StrategySetType Type { get; set; }
		public List<StrategyModel> Strategies { get; set; } = new();
		public StrategySetModel(string strategySetName, StrategySetType type)
		{
			StrategySetName= strategySetName;
			Type = type;
		}
	}
}
