using NUnit.Framework;
using SocksFactory;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocsFactoryTests
{	
	public class ArraysTests
	{
		[Test]
		public void ArraySortTest()
		{
			bool[] data = new bool[] { false, true, true, false, true, false };
			ArrayOperations.SortArray(data);
			Assert.IsTrue(data[0] == false);
			Assert.IsTrue(data[1] == false);
			Assert.IsTrue(data[2] == false);
			Assert.IsTrue(data[3] == true);
			Assert.IsTrue(data[4] == true);
			Assert.IsTrue(data[5] == true);
		}

		[Test]
		public void ArrayMatchTest()
		{
			int[] data1 = { -10, -9, -8, -7, -6, -5, -4, -3, -2, -1, 0 };
			int[] data2 = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			string result = ArrayOperations.ArrayMatch(data1, data2);
			Assert.IsTrue(result == "-10, 10");
		}

		[Test]
		public void SpiralMatrix()
		{
			const string expectedResult = "1, 2, 3, 4, 8, 12, 16, 15, 14, 13, 9, 5, 6, 7, 11, 10, ";			
			int[,] matrix = new int[4, 4]
			{
				{1, 2, 3, 4 },
				{5, 6, 7, 8 },
				{9, 10, 11, 12 },
				{13, 14, 15, 16 },
			};

			string result = ArrayOperations.SpiralMatrix(matrix);
			Assert.IsTrue(result == expectedResult);
		}
		[Test]
		public void BinarySearch()
		{
			int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			int result = ArrayOperations.BinarySearch(data, 8);
			Assert.IsTrue(result == 8);
		}

		[Test]
		public void BinarySearch2()
		{
			int[] data = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
			int result = ArrayOperations.BinarySearch(data, 4);
			Assert.IsTrue(result == 4);
		}

		[Test]
		public void QuickSortTest()
		{
			int[] data = { 4, 1, 3, 2, 9, 5, 8, 6, 7, 10};
			int[] expectedData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			ArrayOperations.QuickSort(data, 0, data.Length - 1);
			Assert.AreEqual(data, expectedData);
		}
		[Test]
		public void BubbleSortTest()
		{
			int[] data = { 4, 1, 3, 2, 9, 5, 8, 6, 7, 10 };
			int[] expectedData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			ArrayOperations.BubbleSort(data);			
			Assert.AreEqual(data, expectedData);
		}
		[Test]
		public void SelectionSortTests()
		{
			int[] data = { 4, 1, 3, 2, 9, 5, 8, 6, 7, 10 };
			int[] expectedData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
			ArrayOperations.SelectionSort(data);
			Assert.AreEqual(data, expectedData);
		}
		[Test]
		public void SearchForMissingNumber()
		{
			int[] data = { 1, 2, 4, 6, 3, 7, 8 };
			int result = ArrayOperations.SearchForMissingNumber(data);
			Assert.IsTrue(result == 5);
		}
		[Test]
		public void SearchForMissingNumber1()
		{
			int[] data = { 1, 2, 4, 6, 3, 7, 8, 5, 10 };
			int result = ArrayOperations.SearchForMissingNumber(data);
			Assert.IsTrue(result == 9);
		}
	}
}

