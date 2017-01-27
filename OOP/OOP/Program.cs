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
			Employee dan = new Employee( "Dan V.", 100000.0 );
			PrintEmployee( dan );
			Employee eddie = new Employee( "Eddie U.", 1000000 );
			PrintEmployee( eddie );
			Employee eric = new Employee("", 50000);
			PrintEmployee( eric );

			Employee nick = new Employee()
			{
				Name = "Nick C.",
				Salary = 250000
			};
			PrintEmployee( nick );

			Employee afeefeh = new Employee();
			afeefeh.Name = "Afeefeh S";
			afeefeh.Salary = double.MaxValue;
			PrintEmployee( afeefeh );
			

			Console.ReadKey();
		}

		static void PrintObjectTypes()
		{
			object[] items = new object[ 3 ];
			items[ 0 ] = new Employee("Dan", 1000000);
			items[ 1 ] = 10;
			items[ 2 ] = "test";

			for ( int index = 0; index < items.Length; index++ )
			{
				PrintEmployee( items[ index ] );
			}
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
