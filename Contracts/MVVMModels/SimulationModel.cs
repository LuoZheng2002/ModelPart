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
        public SimulationModel(Point canvasPos, 
			string simulationModuleName,
			string simulationDescription,
			string simulationModelClassName,
			string player1Name,
			string player2Name,
			string player1SolutionName,
			string player2SolutionName)
        {
			CanvasPos = canvasPos;
			SimulationModuleName = simulationModuleName;
			SimulationDescription = simulationDescription;
			SimulationModelClassName = simulationModelClassName;
			Player1Name = player1Name;
			Player2Name = player2Name;
			Player1SolutionName = player1SolutionName;
			Player2SolutionName = player2SolutionName;
			Player1WinsCaseModel = new CaseModel("__PLAYER1WINS__", "玩家1获胜");
			Player2WinsCaseModel = new CaseModel("__PLAYER2WINS__", "玩家2获胜");
		}
        public SimulationModel()
        {
            
        }
    }
}
