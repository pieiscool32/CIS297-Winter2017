using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	class Program
	{
		static void Main( string[] args )
		{
			Employee dan = new Employee( "Dan V.", 123, 100000.0 );
			PrintEmployee( dan );
			Employee eddie = new Employee( "Eddie U.", 234, 1000000 );
			PrintEmployee( eddie );
			Employee eric = null;
			PrintEmployee( eric );

			object[] items = new object[ 3 ];
			items[ 0 ] = dan;
			items[ 1 ] = eddie;
			items[ 2 ] = "test";

			for ( int index = 0; index< items.Length; index++ )
			{
				PrintEmployee( items[ index ] );
			}

			Console.ReadKey();
		}

		static void PrintEmployee( object obj )
		{
			// this one crashes if it can't cast
			// Employee employee = (Employee)obj; 

			// this equals null if it can't cast
			Employee employee = obj as Employee;
			PrintEmployee( employee );
		}

		static void PrintEmployee( Employee employee )
		{
			if ( employee != null )
			{
				Console.WriteLine( employee.ToString() );
			}
		}
	}
}
