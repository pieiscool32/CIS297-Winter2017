using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	class Program
	{
		static void Main( string[] args )
		{
			Bet<int> bet = new Bet<int>();

			Random random = new Random();

			bet.Mine = random.Next( 1, 100 );
			bet.WagerAmount = 5;
			bet.Theirs = new int[] {
				random.Next( 1, 100 ),
				random.Next( 1, 100 ),
				random.Next( 1, 100 )
			};

			Console.WriteLine( $"I win: {bet.DoBet()}" );

			Console.ReadKey();
		}
	}
}
