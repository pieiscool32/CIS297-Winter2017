using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
	public class Employee
	{
		private string _name;
		private int _idNumber;
		private double _salary;

		public Employee(string name, int idNumber, double salary)
		{
			_name = name;
			_idNumber = idNumber;
			_salary = salary;
		}

		public string getName()
		{
			return _name;
		}

		public int getIDNumber()
		{
			return _idNumber;
		}

		public double getSalary()
		{
			return _salary;
		}

		public override string ToString()
		{
			return $"Name: {getName()} - ID: {getIDNumber()} - Salary: ${getSalary()}";
		}
	}
}
