using System;
using System.Collections.Generic;
using Betting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Betting.Card;

namespace UnitTestProject1
{
	[TestClass]
	public class PokerHandTests
	{
		[TestMethod]
		public void TestIsFullHouse()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			Assert.IsTrue( mine.IsFullHouse() );
		}

		[TestMethod]
		public void TestIsNotFullHouse()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsFalse( mine.IsFullHouse() );
		}


		[TestMethod]
		public void TestIsFlush()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsTrue( mine.IsFlush() );
		}

		[TestMethod]
		public void TestIsNotFlush()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsFalse( mine.IsFlush() );
		}

		[TestMethod]
		public void TestIsStraight()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsTrue( mine.IsStraight() );
		}

		[TestMethod]
		public void TestIsNotStraight()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			Assert.IsFalse( mine.IsStraight() );
		}

		[TestMethod]
		public void TestCompareHighestCards()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );

			PokerHand theirs = new PokerHand( GetOrderdDeck() );
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Jack } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );

			Assert.IsTrue( mine.compareHighestCards( mine.Cards, theirs.Cards ) > 0 );
		}

		[ TestMethod]
		public void TestCompareToHighCard()
		{
			PokerHand mine = new PokerHand( GetOrderdDeck() );
			mine.Cards.Clear();
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );

			PokerHand theirs = new PokerHand( GetOrderdDeck() );
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Jack } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );

			//Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
		}

		[TestMethod]
		public void TestFixedHand()
		{
			PokerHand hand = new PokerHand( GetOrderdDeck() );
			hand.Cards.Clear();
			hand.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			hand.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			hand.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			hand.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			hand.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );

			Assert.AreEqual( Suit.Hearts, hand.Cards[ 0 ].suit );
			Assert.AreEqual( Face.Ace, hand.Cards[ 0 ].face );

			Assert.AreEqual( Suit.Hearts, hand.Cards[ 1 ].suit );
			Assert.AreEqual( Face.King, hand.Cards[ 1 ].face );

			Assert.AreEqual( Suit.Hearts, hand.Cards[ 2 ].suit );
			Assert.AreEqual( Face.Queen, hand.Cards[ 2 ].face );

			Assert.AreEqual( Suit.Hearts, hand.Cards[ 3 ].suit );
			Assert.AreEqual( Face.Jack, hand.Cards[ 3 ].face );

			Assert.AreEqual( Suit.Hearts, hand.Cards[ 4 ].suit );
			Assert.AreEqual( Face.Ten, hand.Cards[ 4 ].face );
		}
	

		[TestMethod]
		public void TestHandFromDeck()
		{
			PokerHand hand = new PokerHand( GetOrderdDeck() );

			Assert.AreEqual( Suit.Spades, hand.Cards[ 0 ].suit );
			Assert.AreEqual( Face.Two, hand.Cards[ 0 ].face );

			Assert.AreEqual( Suit.Spades, hand.Cards[ 1 ].suit );
			Assert.AreEqual( Face.Three, hand.Cards[ 1 ].face );

			Assert.AreEqual( Suit.Spades, hand.Cards[ 2 ].suit );
			Assert.AreEqual( Face.Four, hand.Cards[ 2 ].face );

			Assert.AreEqual( Suit.Spades, hand.Cards[ 3 ].suit );
			Assert.AreEqual( Face.Five, hand.Cards[ 3 ].face );

			Assert.AreEqual( Suit.Spades, hand.Cards[ 4 ].suit );
			Assert.AreEqual( Face.Six, hand.Cards[ 4 ].face );
		}

		private PokerDeck GetOrderdDeck()
		{
			List<int> cardOrder = new List<int>();
			for ( int index = 51; index >= 0; index-- )
			{
				cardOrder.Add( index );
			}
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( cardOrder );
			return new PokerDeck( numberGenerator );
		}
	}
}
