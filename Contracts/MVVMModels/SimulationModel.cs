using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Contracts.MVVMModels
{
	public class SimulationModel:DiagramElementModel
	{
		public override string ClassName => SimulationModelClassName;
		public Point CanvasPos { get; set; }
		public string SimulationModuleName { get; set; } = "";
		public string SimulationDescription { get; set; } = "";
		public string SimulationModelClassName { get; set; } = "";
		public string Player1Name { get; set; } = "";
		public string Player2Name { get; set; } = "";
		public string Player1SolutionName { get; set; } = "";
		public string Player2SolutionName { get; set; } = "";
		public CaseModel Player1WinsCaseModel { get; set; } = new();
		public CaseModel Player2WinsCaseModel { get; set; } = new();
		public bool Player1MovesFirst { get; set; } = false;
        public SimulationModel(Point canvasPos)
        {
			CanvasPos = canvasPos;
			Player1WinsCaseModel = new CaseModel("__PLAYER1WINS__", "玩家1获胜");
			Player2WinsCaseModel = new CaseModel("__PLAYER2WINS__", "玩家2获胜");
		}
        public SimulationModel()
        {
            
        }
    }
}
