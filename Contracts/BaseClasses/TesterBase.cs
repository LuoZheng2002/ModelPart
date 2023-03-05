using Emgu.CV;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contracts.BaseClasses
{
	public abstract class TesterBase
	{
		public abstract void OnLeftButtonDown(double x, double y);
		public abstract void OnRightButtonDown(double x, double y);
		public abstract void OnReceiveMessage(string message);
		public void SendMessage(string message)
		{
			// to do
		}
		public void UpdateImage(Image<Bgr, byte> image)
		{
			// to do
		}
	}
}
