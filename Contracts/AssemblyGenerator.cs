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
			string result = @"
Using System;

namespace Contracts
{
	public class GoGameProjSlnFuncProvider: ProjSlnFuncProviderBase
	{
		public override ProjectSolution GetSolution()
		{
			ProjectSolution projectSolution = new ProjectSolution();
			projectSolution.StrategySets.Add(...) //根据projectModel中的信息填充
			// ...
		}
	}
}
			";
			return result;
		}
	}
}
