using System;
using System.Collections.Generic;
using Betting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class HorseTests
	{
		[TestMethod]
		public void TestMyHorseWins()
		{
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			FakeNumberGenerator mySpeed = new FakeNumberGenerator( new List<int> { 10 } );
			FakeNumberGenerator theirSpeed = new FakeNumberGenerator( new List<int> { 9, 8 } );
			Horse mine = new Horse( mySpeed );
			List<Horse> horses = new List<Horse>
			{
				new Horse(theirSpeed),
				new Horse(theirSpeed)
			};

			horseBet.Mine = mine;
			horseBet.Theirs = horses.ToArray();

			Assert.AreEqual( 15, horseBet.DoBet() );
		}

		[TestMethod]
		public void TestMyHorseLoses()
		{
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			FakeNumberGenerator mySpeed = new FakeNumberGenerator( new List<int> { 1 } );
			FakeNumberGenerator theirSpeed = new FakeNumberGenerator( new List<int> { 9, 8 } );
			Horse mine = new Horse( mySpeed );
			List<Horse> horses = new List<Horse>
			{
				new Horse(theirSpeed),
				new Horse(theirSpeed)
			};

			horseBet.Mine = mine;
			horseBet.Theirs = horses.ToArray();

			Assert.AreEqual( 0, horseBet.DoBet() );
		}


		[TestMethod]
		public void TestMyHorseComparesToLessThan()
		{
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			FakeNumberGenerator mySpeed = new FakeNumberGenerator( new List<int> { 1 } );
			FakeNumberGenerator theirSpeed = new FakeNumberGenerator( new List<int> { 9 } );
			Horse mine = new Horse( mySpeed );
			Horse theirs = new Horse( theirSpeed );

			Assert.IsTrue( mine.CompareTo(theirs) < 0 );
		}


		[TestMethod]
		public void TestMyHorseComparesToGreaterThan()
		{
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			FakeNumberGenerator mySpeed = new FakeNumberGenerator( new List<int> { 10 } );
			FakeNumberGenerator theirSpeed = new FakeNumberGenerator( new List<int> { 9 } );
			Horse mine = new Horse( mySpeed );
			Horse theirs = new Horse( theirSpeed );

			Assert.IsTrue( mine.CompareTo( theirs ) > 0 );
		}

		[TestMethod]
		public void TestMyHorseComparesToEquals()
		{
			Bet<Horse> horseBet = new Bet<Horse>();
			horseBet.WagerAmount = 5;
			FakeNumberGenerator mySpeed = new FakeNumberGenerator( new List<int> { 10 } );
			FakeNumberGenerator theirSpeed = new FakeNumberGenerator( new List<int> { 10 } );
			Horse mine = new Horse( mySpeed );
			Horse theirs = new Horse( theirSpeed );

			Assert.IsTrue( mine.CompareTo( theirs ) == 0 );
		}
	}
}
