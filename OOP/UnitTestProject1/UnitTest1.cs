using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OOP;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestEmployeeConstructorDefaultName()
		{
			Employee testEmployee = new Employee( "", 100000 );
			Assert.AreEqual( "Not Assigned", testEmployee.Name );
			Assert.AreEqual( 100000, testEmployee.AnnualSalary );
		}

		[TestMethod]
		public void TestEmployeeConstructor()
		{
			Employee testEmployee = new Employee( "Eric", 100000 );
			Assert.AreEqual( "Eric", testEmployee.Name );
			Assert.AreEqual( 100000, testEmployee.AnnualSalary );
		}
	}
}
