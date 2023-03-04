using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class SimulationModuleBase:ExecutableBase
	{
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public ExecutableBase? ConnectedToPlayer1Wins { get; set; }
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public ExecutableBase? ConnectedToPlayer2Wins { get; set; }
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public Solution? Player1Solution { get; set; }
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public Solution? Player2Solution { get; set; }
		/// <summary>
		/// 由Strategy Manager自动填充
		/// </summary>
		public bool Player1MovesFirst { get; set; }
		public override MoveInfo ExecuteModule(GameModelBase gameModel, ArgBase? arg)
		{
			MoveInfo moveInfo = new MoveInfo(null, 0.0, true, SimulationStatus.Continue);
			bool player1Turn = Player1MovesFirst;
			bool? player1Wins = null;
			int count = 0;
			GameModelBase simulationGameModel = gameModel.Copy();
			while(true)
			{
				if (player1Turn)
				{
					moveInfo = Player1Solution!.ExecuteModule(simulationGameModel, arg);
					if (moveInfo.Status == SimulationStatus.Win)
					{
						player1Wins = true;
						break;
					}
					else if(moveInfo.Status == SimulationStatus.Lose)
					{
						player1Wins = false;
						break;
					}
					else
					{
						if (moveInfo.Status != SimulationStatus.Continue)
						{
							throw new Exception("SimulationStatus should be Win, Lose or Continue.");
						}
					}
				}
				else
				{
					moveInfo = Player2Solution!.ExecuteModule(simulationGameModel, arg);
					if (moveInfo.Status == SimulationStatus.Win)
					{
						player1Wins = false;
						break;
					}
					else if (moveInfo.Status == SimulationStatus.Lose)
					{
						player1Wins = true;
						break;
					}
					else
					{
						if (moveInfo.Status != SimulationStatus.Continue)
						{
							throw new Exception("SimulationStatus should be Win, Lose or Continue.");
						}
					}
				}
				if (moveInfo.Move == null)
				{
					throw new Exception("Move should not be null");
				}
				gameModel.DoMove(moveInfo.Move);
				player1Turn = !player1Turn;
				count++;
				if (count > 1000)
				{
					throw new Exception("Deadlock.");
				}
			}
			Debug.Assert(player1Wins != null);
			MoveInfo? result = null;
			if (player1Wins.Value)
			{
				result = ConnectedToPlayer1Wins!.ExecuteModule(gameModel, arg);
			}
			else
			{
				result = ConnectedToPlayer2Wins!.ExecuteModule(gameModel, arg);
			}
			return result;
		}
	}
}
