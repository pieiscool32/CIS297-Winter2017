using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
	public class PrimeGenerator
	{
		public static Task<List<int>> GetPrimes()
		{
			return Task.Run( () =>
			{
				List<int> primes = new List<int>();

				int currentNumber = 2;

				while ( primes.Count < 1000000 )
				{
					if ( IsPrime( currentNumber ) )
					{
						primes.Add( currentNumber );
					}
					currentNumber++;
				}
				return primes;
			} );
		}

		public static bool IsPrime( int n )
		{
			if ( n <= 1 ) return false;

			for ( int divisor = 2; divisor < Math.Sqrt( n ); divisor++ )
			{
				if ( n % divisor == 0 )
				{
					return false;
				}
			}
			return true;
		}
	}
}
