using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class SwitchModel:DiagramElementModel
	{
		public Point CanvasPos { get; set; }
		public string StatementName { get; set; }
		public string SwitchClassName { get; set; }
		public int CasCount { get; set; }
		public List<string> CaseNames { get; set; }
	}
}
