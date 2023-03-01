using Contracts.MVVMModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts
{
	public static class AssemblyGenerator
	{
		public static string GenerateCode(ProjectModel projectModel)
		{
			string result = "";
			result += "using System;\n";

			return result;
		}
	}
}
