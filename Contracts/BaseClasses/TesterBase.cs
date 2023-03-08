using Contracts.Communication;
using Emgu.CV;
using Emgu.CV.Structure;
using SMContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using System.Windows.Documents.Serialization;

namespace Contracts.BaseClasses
{
	public abstract class TesterBase
	{
		public ProjSlnFuncProviderBase? ProjSlnFuncProvider { get; set; }
		public abstract void Init();
		public abstract void OnLeftButtonDown(double x, double y);
		public abstract void OnRightButtonDown(double x, double y);
		public abstract void OnReceiveMessage(string message);

		public void SendMessage(string message)
		{
			Console.WriteLine(TextConvention.SendMessage + " " + message);
		}
		public void UpdateImage(Image<Bgr, byte> image)
		{
			byte[,,] data = image.Data;
			byte[][][] jaggedData = data.ToJaggerArray();
			string serializedData = Serializer.Serialize(jaggedData);
			Console.WriteLine(TextConvention.UpdateImage + " " +  serializedData);
			int[,] a;
		}
	}
}
