using System;
using System.Collections.Generic;
using System.Text;

namespace SocksFactory
{
	public static class Valleys
	{
		public static int CountingValleys(int stepsCount, string inputData)
		{
			const int initialLevel = 2;
			int currentLevel = initialLevel;
			int valleys = 0;
			char[] steps = inputData.ToCharArray();
			foreach (char step in steps)
			{
				if (step == 'D')
				{
					currentLevel--;
				}
				else if (step == 'U')
				{
					currentLevel++;
				}
				if (currentLevel == initialLevel && step == 'U')
				{
					valleys++;
				}
			}
			return valleys;
		}
	}
}
