using System;
using System.IO;
using System.Linq;

namespace SocksFactory
{
	public class Program
	{
		// Complete the sockMerchant function below.
		public static int SockMerchant(int socksNumber, int[] socks)
		{
			int pairsNumber = 0;			
			Array.Sort(socks);
			for (int i = 0; i <socks.Length; i++)
			{
				int firstColor = socks[i];
				i++;
				if (i >= socks.Length)
				{
					break;
				}
				int secondColor = socks[i];
				if (firstColor == secondColor)
				{
					pairsNumber++;
				}
				else
				{
					i--;
				}
			}
			return pairsNumber;
		}

		static void Main(string[] args)
		{
			TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

			int n = Convert.ToInt32(Console.ReadLine());

			int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp))
			;
			int result = SockMerchant(n, ar);

			textWriter.WriteLine(result);

			textWriter.Flush();
			textWriter.Close();
		}
	}
}
