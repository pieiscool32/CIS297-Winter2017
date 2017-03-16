using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting;

namespace Holdem
{
	public class Round
	{
		private PokerDeck deck;
		public HoldemHand player { get; private set; }
		public HoldemHand computer { get; private set; }
		public SharedCards shared { get; private set; }

		public Round(INumberGenerator numberGenerator)
		{
			deck = new PokerDeck( numberGenerator );
			player = new HoldemHand
			{
				First = deck.PickCard(),
				Second = deck.PickCard()
			};
			computer = new HoldemHand
			{
				First = deck.PickCard(),
				Second = deck.PickCard()
			};
			shared = new SharedCards()
			{
				Cards = new Card[] { deck.PickCard(), deck.PickCard(), deck.PickCard(), deck.PickCard(), deck.PickCard() }
			};
		}
	}
}
