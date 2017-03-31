using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
	public class InfinityAndBeyond : IEnumerable
	{
		IEnumerator IEnumerable.GetEnumerator()
		{
			int number = 0;
			while ( true )
			{
				yield return number;
				number++;
			}
		}
	}
}
