using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Employee
	{
		private static int NumberOfEmployees = 1;

		private string _name;

		public string Name
		{
			get
			{ 
				return _name;
			}
			set
			{
				if ( value != "" )
				{
					_name = value;
				}
				else
				{
					_name = "Not Assigned";
				}
			}
		}
		public int IDNumber { get; set; }
		public double Salary { get; set; }

		public Employee() : this("", 0)
		{
			// empty
		}
		public Employee(string name, double salary)
		{
			Name = name;
			IDNumber = NumberOfEmployees++;
			Salary = salary;
		}

		public override string ToString()
		{
			return $"Name: {Name} - ID: {IDNumber} - Salary: ${Salary}";
		}
	}
}
