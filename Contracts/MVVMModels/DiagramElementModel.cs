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
	[JsonDerivedType(typeof(StrategySetModel), "StrategySetModel")]
	[JsonDerivedType(typeof(IfModel), "IfModel")]
	[JsonDerivedType(typeof(StartModel), "StartModel")]
	public class DiagramElementModel
	{
	}
}
