﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	public class StartModel:IDiagramElementModel
	{
		public Point CanvasPos { get; set; }
		public IDiagramElementModel? LinkingTo { get; set; }
	}
}
