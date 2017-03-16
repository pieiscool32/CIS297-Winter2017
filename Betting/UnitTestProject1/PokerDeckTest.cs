using System;
using System.Collections.Generic;
using Betting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Betting.Card;

namespace UnitTestProject1
{
	[TestClass]
	public class PokerDeckTests
	{
		[TestMethod]
		public void TestShuffle()
		{
			List<int> cardOrder = new List<int>();
			for ( int index = 51; index >= 0; index-- )
			{ 
				cardOrder.Add( index );
			}
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( cardOrder );
			PokerDeck deck = new PokerDeck( numberGenerator );

			for ( int cardNumber = 0; cardNumber < 52; cardNumber++ )
			{
				Card expectedCard = new Card
				{
					suit = (Suit)( cardNumber / 13 ),
					face = (Face)( cardNumber % 13 + 2 )
				};
				Card topCard = deck.PickCard();
				Assert.AreEqual( expectedCard.suit, topCard.suit );
				Assert.AreEqual( expectedCard.face, topCard.face );
			}
		}
	}
}
