using System;
using System.Collections.Generic;
using System.Text;

namespace SocksFactory
{
	public static class Matrix
	{
		public static int MatrixDiagonals(List<List<int>> arr)
		{			
			int right = arr.Count - 1;
			int result1 = 0;
			int result2 = 0;

			for (int i = 0; i < arr.Count; i++)
			{
				result1 += arr[i][i];
				result2 += arr[i][right - i];				
			}

			return Math.Abs(result1 - result2);
		}
	}
}