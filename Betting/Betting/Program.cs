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


			PokerHand hand1 = new PokerHand( new List<int> { 3, 2, 3, 4, 5 } );
			PokerHand hand2 = new PokerHand( new List<int> { 2, 3, 4, 5, 6 } );

			Bet<PokerHand> pokerBet = new Bet<PokerHand>();
			pokerBet.WagerAmount = 10;
			pokerBet.Mine = hand1;
			pokerBet.Theirs = new[] { hand2 };


			Console.WriteLine( $"Poker bet, I win? : {pokerBet.DoBet()}" );


			Console.ReadKey();
		}
	}
}
