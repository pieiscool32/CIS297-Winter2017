using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1Examples
{
	class Program
	{
		static void Main( string[] args )
		{
			Random random = new Random();
			int magicNumber = random.Next( 1, 100 );
			int usersGuess = 0;
			int numberOfGuess = 0;
			while( usersGuess != magicNumber )
			{
				Console.WriteLine( "Guess a number 1-100" );
				usersGuess = Int32.Parse(Console.ReadLine());
				numberOfGuess++;

				if ( usersGuess > magicNumber )
				{
					Console.WriteLine( "Too high, guess again!" );
				}
				else if ( usersGuess < magicNumber )
				{
					Console.WriteLine( "Too low, guess again!" );
				}
				else
				{
					Console.WriteLine( "You guessed it in " + numberOfGuess + " guesses!" );
				}
			}
			Console.ReadLine();
		}
	}
}
