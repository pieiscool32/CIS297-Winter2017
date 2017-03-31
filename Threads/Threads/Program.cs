using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
	class Program
	{
		static int RunCount = 0;
		private static object threadlock = new object();

		static void Main( string[] args )
		{
			Type primeGenerator = typeof( PrimeGenerator );
			ConstructorInfo[] primeGeneratorConstructors = primeGenerator.GetConstructors();
			MethodInfo[] primeGeneratorMethods = primeGenerator.GetMethods();

			object newObject = primeGeneratorConstructors[ 0 ].Invoke(null);

			MethodInfo isPrime = primeGenerator.GetMethod( "IsPrime" );

			isPrime.Invoke( newObject, new object[] { 2 } );
		}

		public static void InfiniteLoop()
		{
			InfinityAndBeyond infiniteLoop = new InfinityAndBeyond();
			// IEnumerable InfinityAndBeyond will yield return for ever
			foreach ( var number in infiniteLoop )
			{
				Console.WriteLine( number );
			}
		}
		

		public static void ThreadRace()
		{
			Thread t1 = new Thread( RGBColors );
			t1.Start();


			Thread t2 = new Thread( RGBColors );
			t2.Start();

			// joining will allow the thread to finish
			t1.Join();
			t2.Join();

			Console.WriteLine( $"{nameof( RunCount )} :{RunCount}" );
			Console.ReadKey();
		}

		public static void RGBColors()
		{

			for ( int blue = 0; blue < 1000; blue++ )
			{
				// lock ensures only a single thread can be in this block at a time
				lock ( threadlock )
				{
					RunCount = RunCount + 1;
				}
				
				Console.WriteLine( $"{nameof( blue )} {blue}" );
			}


		}

		public static void PrimesAsync()
		{
			// this fires off the async task which runs it's own thread to get the prime list
			var primesTask = GetPrimes();
			var milliseconds = 0;
			while ( !primesTask.IsCompleted )
			{
				Console.WriteLine( $"{nameof( milliseconds )}: {milliseconds}" );
				Console.WriteLine( $"Primes task completed: {primesTask.IsCompleted}" );
				Thread.Sleep( 100 );
				milliseconds += 100;
			}
			Console.ReadKey();
			var primes = primesTask.Result;

			foreach ( var prime in primes )
			{
				Console.WriteLine( prime );
			}
		}

		public static async Task<List<int>> GetPrimes()
		{
			Console.WriteLine( "Starting prime generator" );
			// after we call await, control runs to the place where this method was called as the new thread runs
			var primes = await PrimeGenerator.GetPrimes();
			Console.WriteLine( $"Received {primes.Count} primes" );
			return primes;
		}
	}
}
