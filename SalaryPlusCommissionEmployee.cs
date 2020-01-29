using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
	// This is a derived class that inherits from base class CommissionEmployee
	public class SalaryPlusCommissionEmployee : CommissionEmployee
    {
		// fields and properties

		// base salary per week
		private double _salary;

		public double Salary
		{
			get { return _salary; }
			set { _salary = value; }
		}


		// derived class constructor with call to the base class constructor
		public SalaryPlusCommissionEmployee(int id, string name, double grossSales, double commissionRate, double salary) : base(id, name, grossSales, commissionRate)
		{
			Salary = salary;
		}


		// calculate earnings with call to the base class Earnings() method
		public new double Earnings()
		{
			return Salary + base.Earnings();
		}


		// return string representation of SalaryPlusCommissionEmployee object
		public override string ToString()
		{
			return base.ToString() + $"\nSalary: {Salary:C}";
		}
	}
}
