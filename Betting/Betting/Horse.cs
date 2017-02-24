using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Betting
{
	public class Horse : IComparable<Horse>
	{
		private INumberGenerator _numberGenerator;
		public int Speed { get; private set; }
		public Horse( INumberGenerator numberGenerator )
		{
			_numberGenerator = numberGenerator;
			Race();
		}

		public void Race()
		{
			Speed = _numberGenerator.Next( 1, 100 );
		}

		public int CompareTo( Horse other )
		{
			return Speed.CompareTo( other.Speed );
		}
	}
}
