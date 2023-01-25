using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.RightsManagement;
using System.Text;
using System.Threading.Tasks;
using Contracts.BaseClasses;

namespace Contracts
{
    public class MoveInfo
	{
		public MoveBase? Move { get; set; }
		public double Rating { get; set; }
		public bool Succeeded { get; set; }
		public static MoveInfo Failed { get;} = new MoveInfo();
		public MoveInfo(MoveBase move, double rating)
		{
			Move = move;
			Rating = rating;
			Succeeded = true;
		}
		public MoveInfo()
		{

		}
	}
}
