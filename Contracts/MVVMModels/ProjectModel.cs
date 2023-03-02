using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents.Serialization;

namespace Contracts.MVVMModels
{
	public class ProjectModel
	{
		public string ProjectName { get; set; } = "";
		public string ProjectFolder { get; set; } = "";
		public string ProjectDirectory { get; set; } = "";
		public string VSCodeFolderName { get; set; } = "";
		public string VSCodeFolder => ProjectFolder + "/" + VSCodeFolderName;
		public List<string> SolutionNames { get; set; } = new();
		public string CurrentSolutionFileName { get; set; } = "main.smsln";
		public ProjectModel(string projectName, string projectFolder, string projectDirectory, string vsCodeFolderName)
		{
			ProjectName = projectName;
			ProjectFolder = projectFolder;
			ProjectDirectory = projectDirectory;
			VSCodeFolderName= vsCodeFolderName;
		}
		public ProjectModel()
		{

		}
	}
}
