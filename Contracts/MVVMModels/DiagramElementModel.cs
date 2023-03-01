using System;
using System.Collections.Generic;
using System.Windows;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts.MVVMModels
{
	[JsonDerivedType(typeof(DiagramElementModel), "Base")]
	[JsonDerivedType(typeof(StartModel), "StartModel")]
	[JsonDerivedType(typeof(StrategySetModel), "StrategySetModel")]
	[JsonDerivedType(typeof(IfModel), "IfModel")]
	[JsonDerivedType(typeof(SwitchModel), "SwitchModel")]
	[JsonDerivedType(typeof(SimulationModel), "SimulationModel")]
	public class DiagramElementModel
	{
	}
}
