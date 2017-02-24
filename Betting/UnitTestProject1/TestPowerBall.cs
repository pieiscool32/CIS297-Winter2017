using System;
using System.Collections.Generic;
using Betting;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class TestPowerBall
	{
		[TestMethod]
		public void TestPowerBallCompareToEquals()
		{
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( new List<int> { 1, 2, 3, 4, 5, 6 } );
			PowerBall mine = new PowerBall( numberGenerator );
			PowerBall winning = new PowerBall( numberGenerator );

			Assert.AreEqual( 0, mine.CompareTo( winning ) );
		}
		[TestMethod]
		public void TestPowerBallCompareNotEqual()
		{
			FakeNumberGenerator numberGenerator = new FakeNumberGenerator( new List<int> { 1, 2, 3, 4, 5, 6, 7} );
			PowerBall mine = new PowerBall( numberGenerator );
			PowerBall winning = new PowerBall( numberGenerator );

			Assert.AreEqual( -1, mine.CompareTo( winning ) );
		}
	}
}
