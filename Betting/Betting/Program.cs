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
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			RandomNumberGenerator random = new RandomNumberGenerator();
			Horse mine = new Horse( random );
			List<Horse> horses = new List<Horse>
			{
				new Horse(random),
				new Horse(random)
			};

			horseBet.Mine = mine;
			horseBet.Theirs = horses.ToArray();

			Console.WriteLine( $"I win ${horseBet.DoBet()}" );

			mine.Race();
			foreach( Horse theirs in horses )
			{
				theirs.Race();
			}

			Console.WriteLine( $"I win ${horseBet.DoBet()}" );


			PowerBall myPowerBall = new PowerBall( random );
			PowerBall theirPowerBall = new PowerBall( random );

			LotteryBet<PowerBall> powerBall = new LotteryBet<PowerBall>();
			powerBall.Mine = new[] { myPowerBall };
			powerBall.WinningTicket = theirPowerBall;

			int numberOfTicketsUntilJackpot = 0;

			while ( powerBall.DoBet() == 0 )
			{
				powerBall.Mine = new[] { new PowerBall( random ) };
				numberOfTicketsUntilJackpot++;
				if ( numberOfTicketsUntilJackpot % 100000 == 0 )
				{
					Console.WriteLine( $"Currently on ticket #{numberOfTicketsUntilJackpot}" );
				}
			}

			Console.WriteLine( $"It took {numberOfTicketsUntilJackpot} tickets to get a jackpot!" );

			Console.ReadKey();
		}
	}
}