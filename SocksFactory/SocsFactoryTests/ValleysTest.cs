using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocksFactory;

namespace SocsFactoryTests
{
	public class ValleysTest
	{
		[Test]
		public void Test1()
		{
			string dataInput = "DDUUDDUDUUUD";
			char[] data1 = dataInput.ToCharArray();
			int result = Valleys.CountingValleys(data1.Length, dataInput);
			Assert.IsTrue(result == 2);
		}

		[Test]
		public void Test2()
		{
			string dataInput = "UDDDUDUU";
			int result = Valleys.CountingValleys(8, dataInput);
			Assert.IsTrue(result == 1);
		}
	}
}
