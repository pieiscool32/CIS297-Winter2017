using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	public class PokerHand : IComparable<PokerHand>
	{
		public List<int> Cards { get; set; }

		public PokerHand( List<int> cards )
		{
			Cards = cards;
		}

		public int CompareTo( PokerHand other )
		{
			return Cards[ 0 ].CompareTo( other.Cards[ 0 ] );
		}
	}
}
