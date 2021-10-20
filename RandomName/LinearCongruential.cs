using System;
using System.Collections.Generic;
using System.Text;

namespace RandomName
{
	class LinearCongruential
	{
		// X(i) = (a * X(i-1) + c) mod m
		// a – is the multiplier
		// c – is the increment 
		// m – is the modulus

		//Must follow conditions:
		// m > 0 (No divide by 0)
		// 0 < a<m
		// 0 ≤ c<m 
		// 0 ≤ X<m

		private const long a = 25214903917;
		private const long c = 11;
		private long seed;

		public LinearCongruential(long seed)
		{
			if (seed < 0)
				throw new Exception("Seed cannot be equal or less than 0");
			this.seed = seed;
		}

		// helper method
		private int next(int bits)
		{
			seed = (seed * a + c) & ((1L << 48) - 1);
			return (int)(seed >> (48 - bits));
		}

		public double Next()
		{
			return (((long)next(26) << 27) + next(27)) / (double)(1L << 53);
		}
	}
}
