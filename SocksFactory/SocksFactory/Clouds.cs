using System;
using System.Collections.Generic;
using System.Text;

namespace SocksFactory
{
	public class Clouds
	{
		public static int JumpingOnClouds(int[] clouds)
		{
			int jumpsTotal = 0;			
			for (int i = 1; i < clouds.Length; i++)
			{
				int nextJump = i + 1;
				if (nextJump >= clouds.Length)
				{
					nextJump--;
					//break;
				}
				int cloud = clouds[nextJump];
				if (cloud == 0)
				{
					i++;
				}
				jumpsTotal++;

			}
			return jumpsTotal;
		}
	}
}
