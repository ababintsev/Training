namespace SocksFactory
{
	public static class ArrayOperations
	{		
		public static void SortArray(bool[] data)
		{
			int j = -1;									//1
			for (int i = 0; i < data.Length ; i++)		//1 + n + 1 + 1 = 4
			{
				if (data[i] == false)					//1
				{
					j++;								//1
					bool temp = data[j];				//2
					data[j] = data[i];					//2
					data[i] = temp;						//2
				}
			}
		}

		//T = 1 + 4n + 8
		//O(n)


		public static string ArrayMatch(int[] data1, int[] data2) //TO DO: O(n)
		{
			string result = string.Empty;
			for(int i = 0; i < data1.Length; i++)
			{
				if (data1[i] + data2[i] == 0)
				{
					result += $"({data1[i]}, {data2[i]})";
				}
			}
			return result;
		}
		//T = 1 + 1 + 1 + N + N + (2 + 1 + N + N + (1 + 2 + 1 + 1 + 2))*N

		public static string SpiralMatrix(int[,] matrix)
		{			
			string result = string.Empty;
			int x = matrix.GetLength(0);
			int y = matrix.Length / x;
			int row = 0;
			int column = 0;			
			while (row < y && column < x)
			{
				//first row
				for (int i = row; i < x; ++i)
				{
					result += $"{matrix[row, i].ToString()}, ";
				}

				row++;

				//last column
				for (int j = row; j < y; ++j)
				{
					result += $"{matrix[j, y - 1].ToString()}, ";
				}

				x--;
				
				//last row
				for (int i = x - 1; i >= column; --i)
				{
					result += $"{matrix[y - 1, i].ToString()}, ";
				}
				y--;


				//first column
				for (int i = y - 1; i >= row; --i)
				{
					result += $"{matrix[i, column].ToString()}, ";
				}

				column++;
			}

			return result;
		}

		public static int BinarySearch(int[] data, int lookingFor)
		{
			int left = 0;
			int right = data.Length -1;			
			while (left <= right)
			{
				int middle = (left + right) / 2;
				if (data[middle] < lookingFor)
				{
					left = middle + 1;
				}
				else if (data[middle] > lookingFor)
				{
					right = middle - 1;
				}
				else
				{
					return ++middle;
				}
			}
			return -1;
		}

		public static void BubbleSort(int[] data)
		{
			
			for (int i = 0; i < data.Length; i++)
			{
				for (int j = data.Length - 1; j > i; j--)
				{
					if (data[j] < data[j-1])
					{
						int temp = data[j];
						data[j] = data[j - 1];
						data[j - 1] = temp;
					}
				}
			}
		}

		public static int SearchForMissingNumber(int[] data)
		{
			int arraySum = data.Length * (data.Length + 1) / 2;
			for(int i = 0; i < data.Length - 1; i++)
			{
				arraySum -= data[i];
			}
			return arraySum;
		}

		public static void QuickSort(int[] data, int start, int end)
		{
			if (start < end)
			{
				int partition = Partition(data, start, end);
				QuickSort(data, start, partition - 1);
				QuickSort(data, partition + 1, end);
			}
		}
		private static int Partition(int[] data, int start, int end)
		{
			int temp;
			int pivot = data[end];
			int j = start - 1;
			for (int i = start; i <= end - 1; i++)
			{
				if (data[i] <= pivot)
				{
					j++;
					temp = data[j];
					data[j] = data[i];
					data[i] = temp;
				}
			}
			temp = data[j + 1];
			data[j + 1] = data[end];
			data[end] = temp;
			return j + 1;
		}

		public static void SelectionSort(int[] data)
		{
			int minValue;			

			for (int i = 0; i < data.Length; i++)
			{
				minValue = i;
				
				for (int j = i; j < data.Length; j++)
				{
					if (data[j] < data[minValue])
					{
						minValue = j;						
					}
				}
				if (minValue > i)
				{
					int temp = data[i];
					data[i] = data[minValue];
					data[minValue] = temp;
				}
			}
		}
	}
}
