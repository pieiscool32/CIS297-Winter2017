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
		public void TestStraightBeatsPair()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
		}

		[TestMethod]
		public void TestStraightFlushAreEqual()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.AreEqual( 0, mine.CompareTo( theirs ) );
		}

		[TestMethod]
		public void TestStraightFlushGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestFlushAreEqual()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Nine } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.AreEqual( 0, mine.CompareTo( theirs ) );
		}

		[TestMethod]
		public void TestFlushGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Nine } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestStraightAreEqual()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Jack } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Nine } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			Assert.AreEqual( 0, mine.CompareTo( theirs ) );
		}

		[TestMethod]
		public void TestStraightGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Nine } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Jack } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestFourOfAKindGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestThreeOfAKindGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestTwoPairAreEqual()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.AreEqual( 0, mine.CompareTo( theirs ) );
		}

		[TestMethod]
		public void TestTwoPairIsGreaterWithFifthCard()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Five } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestTwoPairGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestPairGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Five } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Five } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestPairGreaterAndLessWithOtherCards()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Seven } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Five } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestHighCardGreaterAndLess()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Five } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Two } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Five } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Three } );
			theirs.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Two } );
			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
			Assert.IsTrue( theirs.CompareTo( mine ) < 0 );
		}

		[TestMethod]
		public void TestHasPair()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );
			Assert.IsTrue( mine.HasPair() );
		}

		[TestMethod]
		public void TestHasThreeOfAKind()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			Assert.IsTrue( mine.HasThreeOfAKind() );
		}

		[TestMethod]
		public void TestHasFourOfAKind()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Clubs, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );
			Assert.IsTrue( mine.HasFourOfAKind() );
		}

		[TestMethod]
		public void TestIsFullHouse()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			Assert.IsTrue( mine.HasFullHouse() );
		}

		[TestMethod]
		public void TestIsNotFullHouse()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsFalse( mine.HasFullHouse() );
		}


		[TestMethod]
		public void TestIsFlush()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsTrue( mine.HasFlush() );
		}

		[TestMethod]
		public void TestIsNotFlush()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsFalse( mine.HasFlush() );
		}

		[TestMethod]
		public void TestIsStraight()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ten } );
			Assert.IsTrue( mine.HasStraight() );
		}

		[TestMethod]
		public void TestIsNotStraight()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );
			Assert.IsFalse( mine.HasStraight() );
		}

		[TestMethod]
		public void TestCompareHighestCards()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Jack } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );

			Assert.IsTrue( mine.compareHighestCards( mine.Cards, theirs.Cards ) > 0 );
		}

		[TestMethod]
		public void TestCompareToHighCard()
		{
			PokerHand mine = new PokerHand();

			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Ace } );
			mine.Cards.Add( new Card { suit = Suit.Spades, face = Face.King } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Queen } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Jack } );
			mine.Cards.Add( new Card { suit = Suit.Hearts, face = Face.Nine } );

			PokerHand theirs = new PokerHand();
			theirs.Cards.Clear();
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Ace } );
			theirs.Cards.Add( new Card { suit = Suit.Clubs, face = Face.King } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Queen } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Jack } );
			theirs.Cards.Add( new Card { suit = Suit.Diamonds, face = Face.Eight } );

			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
		}

		[TestMethod]
		public void TestFixedHand()
		{
			PokerHand hand = new PokerHand();
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
