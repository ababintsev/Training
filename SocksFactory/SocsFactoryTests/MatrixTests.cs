using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocksFactory;

namespace SocsFactoryTests
{
	public class MatrixTests
	{
		[Test]
		public void SumOfDiagonalsTest()
		{
			int n = 3;
			List<List<int>> arr = new List<List<int>>();
			string[] inputData = new string[]
			{
				"11 2 4",
				"4 5 6",
				"10 8 -12"
			};

			for (int i = 0; i < n; i++)
			{
					
					arr.Add(inputData[i].Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
					
			}
			

			int result = Matrix.MatrixDiagonals(arr);
			Assert.IsTrue(result == 15);
		}		
	}
}
