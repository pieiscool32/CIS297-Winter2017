using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Betting;

namespace Betting
{
	public class PowerBall : IComparable<PowerBall>, ILottery
	{
		public List<int> WhiteBalls { get; private set; }
		public int RedBall { get; private set; }
		public PowerBall( INumberGenerator numberGenerator )
		{
			WhiteBalls = new List<int>();

			for ( int ballNumber = 1; ballNumber <= 5; ballNumber++ )
			{
				int number = numberGenerator.Next( 1, 70 );
				while ( WhiteBalls .Contains(number) )
				{
					number = numberGenerator.Next( 1, 70 );
				}
				WhiteBalls.Add( number );
			}

			RedBall = numberGenerator.Next( 1, 27 );
		}

		public int CompareTo( PowerBall other )
		{
			foreach ( int number in WhiteBalls )
			{
				if ( !other.WhiteBalls.Contains(number) )
				{
					return -1;
				}
			}
			if ( RedBall == other.RedBall )
			{
				return 0;
			}
			else
			{
				return -1;
			}
		}

		public int GrandPrize()
		{
			return 435000000;
		}
	}
}
