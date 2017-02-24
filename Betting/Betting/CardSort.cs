using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	public class CardSort : IComparer<Card>
	{
		public int Compare( Card first, Card second )
		{
			return second.face.CompareTo( first.face );
		}
	}
}
