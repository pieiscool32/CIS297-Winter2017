using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting;
using Holdem;

namespace Holdem
{
	public class HoldemHand
	{
		public Card First { get; set; }
		public Card Second { get; set; }

		public PokerHand GetBestHand( SharedCards shared )
		{
			List<Card> cards = new List<Card>();
			cards.Add( First );
			cards.Add( Second );
			cards.AddRange( shared.Cards );

			List<PokerHand> possibleHands = GetAllPossibleHands( cards );

			PokerHand bestHand = possibleHands[ 0 ];
			for ( int index = 1; index < possibleHands.Count; index++ )
			{
				if ( bestHand.CompareTo( possibleHands[ index ] ) < 0 )
				{
					bestHand = possibleHands[ index ];
				}
			}

			return bestHand;
		}

		public double GetOddsOfWinning( SharedCards shared )
		{
			PokerDeck deck = new PokerDeck( new RandomNumberGenerator() );
			List<Card> remainingCards = new List<Card>();
			while ( deck.CardsRemaining > 0 )
			{
				Card nextCard = deck.PickCard();
				if ( !nextCard.Equals( First ) && !nextCard.Equals( Second ) && shared.Cards.All( c => !c.Equals(nextCard) ) )
				{
					remainingCards.Add( nextCard );
				}
			}

			List<HoldemHand> possibleHands = new List<HoldemHand>();

			for ( int firstIndex = 0; firstIndex < remainingCards.Count - 1; firstIndex++ )
			{
				for ( int secondIndex = firstIndex + 1; secondIndex < remainingCards.Count; secondIndex++ )
				{
					possibleHands.Add( new HoldemHand
					{
						First = remainingCards[ firstIndex ],
						Second = remainingCards[ secondIndex ]
					} );
				}
			}

			double potentialWins = 0;
			double potentialDraws = 0;
			double potentialLosses = 0;
			PokerHand myBestHand = GetBestHand( shared );

			foreach ( HoldemHand hand in possibleHands )
			{
				int compareTo = myBestHand.CompareTo( hand.GetBestHand(shared) );

				if ( compareTo < 0 )
				{
					potentialLosses++;
				}
				else if ( compareTo > 0 )
				{
					potentialWins++;
				}
				else
				{
					potentialDraws++;
				}
			}

			return potentialWins / possibleHands.Count;
		}

		private List<PokerHand> GetAllPossibleHands( List<Card> cards )
		{
			List<PokerHand> hands = new List<PokerHand>();

			for ( int firstIndex = 0; firstIndex <= 2; firstIndex++ )
			{
				for ( int secondIndex = firstIndex + 1; secondIndex <= 3; secondIndex++ )
				{
					for ( int thirdIndex = secondIndex + 1; thirdIndex <= 4; thirdIndex++ )
					{
						for ( int fourthIndex = thirdIndex + 1; fourthIndex <= 6; fourthIndex++ )
						{
							for ( int fifthIndex = fourthIndex + 1; fifthIndex < 7; fifthIndex++ )
							{
								PokerHand hand = new PokerHand();
								hand.Cards.Add( cards[ firstIndex ] );
								hand.Cards.Add( cards[ secondIndex ] );
								hand.Cards.Add( cards[ thirdIndex ] );
								hand.Cards.Add( cards[ fourthIndex ] );
								hand.Cards.Add( cards[ fifthIndex ] );
								hands.Add( hand );
							}
						}
					}
				}
			}

			return hands;
		}
	}
}
