using System;
using System.Collections.Generic;
using static Betting.Card;

namespace Betting
{
	public class PokerDeck
	{
		public int CardsRemaining => _cards.Count;
		private Stack<Card> _cards;

		public PokerDeck( INumberGenerator numberGenerator )
		{
			_cards = new Stack<Card>( 52 );
			List<Card> newDeck = new List<Card>();
			for ( int cardNumber = 0; cardNumber < 52; cardNumber++ )
			{
				newDeck.Add( new Card
				{ 
					suit = (Suit)( cardNumber / 13 ),
					face = (Face)( cardNumber % 13 + 2) } );
			}
			while ( newDeck.Count != 0 )
			{
				int randomIndex = numberGenerator.Next( 0, newDeck.Count );
				_cards.Push( newDeck[ randomIndex ] );
				newDeck.RemoveAt( randomIndex );
			}
		}

		public Card PickCard()
		{
			if ( _cards.Count == 0 )
			{
				throw new IndexOutOfRangeException( "No cards left!" );
			}
			return _cards.Pop();
		}
	}
}