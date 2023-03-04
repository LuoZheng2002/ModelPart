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
		public override string ClassName => StrategySetName;
		public Point CanvasPos { get; set; }
		public string StrategySetName { get; set; } = "";
		public string StrategySetDescription { get; set; } = "";
		public StrategySetType Type { get; set; }
		public List<StrategyModel> Strategies { get; set; } = new();
		public StrategySetModel(StrategySetType type, Point canvasPos)
		{
			Type = type;
			CanvasPos = canvasPos;
		}
		public StrategySetModel(){}
	}
}
