using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	[Serializable]
	public class ProjectModel
	{
		public string ProjectName { get; set; } = "";
		public string ProjectFolder { get; set; } = "";
		public string ProjectDirectory { get; set; } = "";
		public string VisualStudioSolutionName { get; set; } = ""; 
		public SolutionModel? MainSolutionModel { get; set; }
		public List<SolutionModel> SolutionModels { get; set; } = new();
		public ProjectModel(string projectName, string projectFolder, string projectDirectory, string visualStudioSolutionName)
		{
			ProjectName = projectName;
			ProjectFolder = projectFolder;
			ProjectDirectory = projectDirectory;
			VisualStudioSolutionName= visualStudioSolutionName;
			MainSolutionModel  = new SolutionModel("main");
			SolutionModels.Add(MainSolutionModel);
			//test
			SolutionModel testSolutionModel = new SolutionModel("test");
			SolutionModels.Add(testSolutionModel);
		}
		public ProjectModel()
		{}
	}
}
