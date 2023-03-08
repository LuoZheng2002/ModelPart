using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Contracts
{
	public static class Serializer
	{
		private static JsonSerializerOptions unindentOptions = new()
		{
			WriteIndented = false,
			ReferenceHandler = ReferenceHandler.Preserve
		};
		private static JsonSerializerOptions indentOptions = new()
		{
			WriteIndented = true,
			ReferenceHandler = ReferenceHandler.Preserve
		};
		public static void Serialize<T>(string filename, T data)
		{
			string result = JsonSerializer.Serialize(data, indentOptions);
			File.WriteAllText(filename, result);
		}
		public static string Serialize<T>(T data)
		{
			string result = JsonSerializer.Serialize(data, unindentOptions);
			return result;
		}
		public static T DeserializeString<T>(string data)
		{
			T? result = JsonSerializer.Deserialize<T>(data, unindentOptions);
			if (result == null)
			{
				throw new Exception("Failed to deserialize!");
			}
			return result!;
		}
		public static T Deserialize<T>(string filename)
		{
			string data = File.ReadAllText(filename);
			T? result = JsonSerializer.Deserialize<T>(data, indentOptions);
			if (result == null)
			{
				throw new Exception("Failed to deserialize!");
			}
			return result!;
		}
	}
}
