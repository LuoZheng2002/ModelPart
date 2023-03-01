using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class CaseModel
	{
		public string CaseName { get; set; } = "";
		public string CaseText { get; set; } = "";
		public DiagramElementModel? LinkingTo { get; set; }
		public CaseModel(string caseName, string caseText)
		{
			CaseName = caseName;
			CaseText = caseText;
		}
		public CaseModel()
		{

		}
	}
}
