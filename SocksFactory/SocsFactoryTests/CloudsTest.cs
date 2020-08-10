using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SocksFactory;

namespace SocsFactoryTests
{
	public class CloudsTest
	{
		[Test]
		public void SampleTest1()
		{
			string data = "0 0 1 0 0 1 0";
			int[] clouds = data.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
			int result = Clouds.JumpingOnClouds(clouds);
			Assert.IsTrue(result == 4);
		}

		[Test]
		public void SampleTest2()
		{
			string data = "0 0 0 1 0 0";
			int[] clouds = data.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
			int result = Clouds.JumpingOnClouds(clouds);
			Assert.IsTrue(result == 3);
		}
		[Test]
		public void Test2()
		{
			string data = "0 0 1 0 0 0 0 1 0 0";
			int[] clouds = data.Split(" ").Select(x => Convert.ToInt32(x)).ToArray();
			int result = Clouds.JumpingOnClouds(clouds);
			Assert.IsTrue(result == 6);
		}
	}
}
