using NUnit.Framework;
using System;
using System.Linq;
using SocksFactory;

namespace SocsFactoryTests
{
	public class Tests
	{

		[SetUp]
		public void Setup()
		{
		}

		[Test]
		public void Test1()
		{
			string dataString = "10 20 20 10 10 30 50 10 20";
			int[] data1 = dataString.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
			int result = Program.SockMerchant(data1.Length, data1);
			Assert.IsTrue(result == 3);
		}
		[Test]
		public void Test2()
		{
			string dataString = "1 1 3 1 2 1 3 3 3 3";
			int[] data1 = dataString.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
			int result = Program.SockMerchant(data1.Length, data1);
			Assert.IsTrue(result == 4);
		}
		[Test]
		public void Test3()
		{
			string dataString = "4 5 5 5 6 6 4 1 4 4 3 6 6 3 6 1 4 5 5 5";
			int[] data1 = dataString.Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
			int result = Program.SockMerchant(data1.Length, data1);
			Assert.IsTrue(result == 9);
		}
	}
}