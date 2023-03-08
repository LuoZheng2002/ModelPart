using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMContracts
{
	public static class ExtensionMethods
	{
		public static T[][] ToJaggedArray<T>(this T[,] twoDimensionalArray)
		{
			int rowsFirstIndex = twoDimensionalArray.GetLowerBound(0);
			int rowsLastIndex = twoDimensionalArray.GetUpperBound(0);
			int numberOfRows = rowsLastIndex + 1;

			int columnsFirstIndex = twoDimensionalArray.GetLowerBound(1);
			int columnsLastIndex = twoDimensionalArray.GetUpperBound(1);
			int numberOfColumns = columnsLastIndex + 1;

			T[][] jaggedArray = new T[numberOfRows][];
			for (int i = rowsFirstIndex; i <= rowsLastIndex; i++)
			{
				jaggedArray[i] = new T[numberOfColumns];

				for (int j = columnsFirstIndex; j <= columnsLastIndex; j++)
				{
					jaggedArray[i][j] = twoDimensionalArray[i, j];
				}
			}
			return jaggedArray;
		}
		public static T[][][] ToJaggerArray<T>(this T[,,] threeDimensionalArray) 
		{
			int rowCount = threeDimensionalArray.GetLength(0);
			int columnCount = threeDimensionalArray.GetLength(1);
			int depthCount = threeDimensionalArray.GetLength(2);
			T[][][] jaggedArray = new T[rowCount][][];
			for (int i = 0;i < rowCount; i++)
			{
				jaggedArray[i] = new T[columnCount][];
				for(int j = 0; j < columnCount; j++)
				{
					jaggedArray[i][j] = new T[depthCount];
					for(int k = 0;k<depthCount;k++)
					{
						jaggedArray[i][j][k] = threeDimensionalArray[i,j,k];
					}
				}
			}
			return jaggedArray;
		}
		public static T[,] To2D<T>(T[][] source)
		{
			try
			{
				int FirstDim = source.Length;
				int SecondDim = source.GroupBy(row => row.Length).Single().Key; // throws InvalidOperationException if source is not rectangular

				var result = new T[FirstDim, SecondDim];
				for (int i = 0; i < FirstDim; ++i)
					for (int j = 0; j < SecondDim; ++j)
						result[i, j] = source[i][j];

				return result;
			}
			catch (InvalidOperationException)
			{
				throw new InvalidOperationException("The given jagged array is not rectangular.");
			}
		}
		public static T[,,] To3D<T>(this T[][][] jaggedArray)
		{
			int rowCount = jaggedArray.Length;
			int columnCount = jaggedArray[0].Length;
			int depthCount = jaggedArray[0][0].Length;
			T[,,] result = new T[rowCount, columnCount, depthCount];
			for(int i = 0;i < rowCount;i++)
			{
				for(int j = 0;j < columnCount;j++)
				{
					for(int k = 0;k < depthCount;k++)
					{
						result[i, j, k] = jaggedArray[i][j][k];
					}
				}
			}
			return result;
		}
	}
}
