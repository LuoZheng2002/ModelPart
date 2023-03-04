using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Contracts.BaseClasses;

namespace Contracts
{
	public enum SimulationStatus
	{
		None,
		Continue,
		Win,
		Lose
	}
    public class MoveInfo
	{
		public MoveBase? Move { get; set; }
		public double Rating { get; set; }
		public bool Succeeded { get; set; }
		public SimulationStatus Status { get; set; }
		public static MoveInfo Failed { get;} = new MoveInfo();
		public MoveInfo(MoveBase? move, double rating, bool succeeded=true, SimulationStatus status=SimulationStatus.None)
		{
			Move = move;
			Rating = rating;
			Succeeded = succeeded;
			Status = status;
		}
		public MoveInfo()
		{

		}
	}
}
