using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreCSharp
{
	public class Triangle
	{
		private int side1;
		private int side2;
		private int hypotenuse;

		public Triangle()
		{
			side1 = 0;
			side2 = 0;
			hypotenuse = 0;
		}

		public void setSides( int one, int two, int three)
		{
			side1 = one;
			side2 = two;

			if ( !(Math.Sqrt(one * one + two * two) == three ) )
			{
				throw new InvalidOperationException( "The hypotenuse must each sqrt(side1^2 + side2^2)" );
			}

			hypotenuse = three;
		}
	}
}
