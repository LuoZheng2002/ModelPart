using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Contracts.MVVMModels
{
	public class IfModel:DiagramElementModel
	{
		public Point CanvasPos { get; set; }
		public string IfModuleName { get; set; } = "";
		public string IfStatementText { get; set; } = "";
		public string IfModelClassName { get; set; } = "";

		public CaseModel TrueCaseModel { get; set;} = new();
		public CaseModel FalseCaseModel { get; set;} = new();

		public IfModel(Point canvasPos)
		{
			CanvasPos = canvasPos;
			TrueCaseModel = new CaseModel("__TRUE__", "True");
			FalseCaseModel = new CaseModel("__FALSE__", "False");
		}
		public IfModel()
		{

		}
	}
}
