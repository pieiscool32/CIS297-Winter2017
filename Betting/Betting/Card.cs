using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	public class Card
	{
		public enum Suit { Spades, Hearts, Clubs, Diamonds };
		public enum Face { Ace = 14, King = 13, Queen = 12, Jack = 11, Ten = 10, Nine = 9, Eight = 8, Seven = 7, Six = 6, Five = 5, Four = 4, Three = 3, Two = 2 }

		public Suit suit { get; set; }
		public Face face { get; set; }
	}
}
