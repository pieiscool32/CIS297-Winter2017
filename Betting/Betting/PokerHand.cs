using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Betting.Card;

namespace Betting
{
	public class PokerHand : IComparable<PokerHand>
	{
		public List<Card> Cards { get; private set; }

		public PokerHand( PokerDeck deck )
		{
			Cards = new List<Card>();
			for ( int cardNumber = 1; cardNumber <= 5; cardNumber++ )
			{
				Cards.Add( deck.PickCard() );
			}
		}

		public int CompareTo( PokerHand other )
		{
			return -1;
		}

		public bool IsStraight()
		{
			Cards.Sort( new CardSort() );
			for ( int index = 0; index < Cards.Count - 1; index++ )
			{
				if ( !( Cards[ index ].face - 1 == Cards[ index + 1 ].face ) )
				{
					return false;
				}
			}
			return true;
		}

		public bool IsFullHouse()
		{
			List<int> faceCount = new List<int> { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
			foreach ( Card card in Cards )
			{
				faceCount[ (int)card.face ]++;
			}

			bool hasThreeOfAKind = false;
			for( int index = 0; index < faceCount.Count; index++ )
			{
				if (faceCount[index] == 3)
				{
					hasThreeOfAKind = true;
				}
			}

			bool hasTwoOfAKind = false;
			for ( int index = 0; index < faceCount.Count; index++ )
			{
				if ( faceCount[ index ] == 2 )
				{
					hasTwoOfAKind = true;
				}
			}

			return hasTwoOfAKind && hasThreeOfAKind;
		}

		public bool IsFlush()
		{
			Suit flushSuit = Cards[ 0 ].suit;
			for ( int index = 1; index < Cards.Count; index++ )
			{
				if ( flushSuit != Cards[ index ].suit )
				{
					return false;
				}
			}
			return true;
		}

		public int compareHighestCards( List<Card> mine, List<Card> theirs )
		{
			mine.Sort( new CardSort() );
			theirs.Sort( new CardSort() );

			for ( int index = 0; index < mine.Count; index++ )
			{
				if ( !( mine[ index ].face == theirs[ index ].face ) )
				{
					return mine[ index ].face.CompareTo( theirs[ index ].face );
				}
			}

			return -1;

		}
	}
}
