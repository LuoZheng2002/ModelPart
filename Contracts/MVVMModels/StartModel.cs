using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class StartModel:DiagramElementModel,ILinkSource
	{
		public Point CanvasPos { get; set; }
		public DiagramElementModel? LinkingTo { get; set; }
		public StartModel(Point canvasPos)
		{
			CanvasPos = canvasPos;
		}
		// for deserialization
		public StartModel()
		{
		}
	}
}
