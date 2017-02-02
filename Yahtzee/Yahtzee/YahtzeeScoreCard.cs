using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
	public class YahtzeeScoreCard
	{
		public static int FULL_HOUSE_SCORE = 25;
		public static int SMALL_STRAIGHT_SCORE = 30;
		public static int LARGE_STRAIGHT_SCORE = 40;
		public static int YAHTZEE_SCORE = 50;
		public int Ones { get; set; }
		public int Twos { get; set; }
		public int Threes { get; set; }
		public int Fours { get; set; }
		public int Fives { get; set; }
		public int Sixes { get; set; }
		public int ThreeOfAKind { get; set; }
		public int FourOfAKind { get; set; }
		public int FullHouse { get; set; }
		public int SmallStraight { get; set; }
		public int LargeStraight { get; set; }
		public int Yahtzee { get; set; }
		public int Chance { get; set; }
	}
}
