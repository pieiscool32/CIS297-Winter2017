using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	public class LotteryBet<T> where T : IComparable<T>, ILottery
	{
		public T[] Mine { get; set; }
		public T WinningTicket { get; set; }

		public int WagerAmount { get; set; }

		public int DoBet()
		{
			if ( Mine == null || WinningTicket == null )
			{
				throw new InvalidOperationException( "Must define Mine and Theirs before betting" );
			}
			if ( Mine.Length == 0 )
			{
				return 0;
			}

			foreach( T ticket in Mine )
			{
				if ( ticket.CompareTo(WinningTicket ) == 0 )
				{
					return ticket.GrandPrize();
				}
			}
			return 0;
		}
	}
}
