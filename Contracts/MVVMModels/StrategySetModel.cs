using Contracts.Enums;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class StrategySetModel:DiagramElementModel
	{
		public Point CanvasPos { get; set; }
		public string StrategySetName { get; set; } = "";
		public StrategySetType Type { get; set; }
		public List<StrategyModel> Strategies { get; set; } = new();
		public event Action<DiagramElementModel>? Destroy;
		public StrategySetModel(string strategySetName, StrategySetType type, Point canvasPos)
		{
			StrategySetName= strategySetName;
			Type = type;
			CanvasPos = canvasPos;
		}
		public StrategySetModel(){}
	}
}
