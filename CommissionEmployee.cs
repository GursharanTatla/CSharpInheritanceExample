using System;
using System.Collections.Generic;
using System.Text;

namespace InheritanceExample
{
	// Base class that represents a commission employee
	public class CommissionEmployee
    {
		// fields and properties

		private int _id;

		public int Id
		{
			get { return _id; }
			set { _id = value; }
		}


		private string _name;

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}


		// gross weekly sales
		private double _grossSales;

		public double GrossSales
		{
			get { return _grossSales; }
			set
			{
				if (value < 0)
					throw new Exception("Gross sales must be >= 0");

				_grossSales = value;
			}
		}


		// commission percentage
		private double _commissionRate;

		public double CommissionRate
		{
			get { return _commissionRate; }
			set
			{
				if (value < 0.0 || value > 1.0)
					throw new Exception("Commission rate must be >=0 or <=1");

				_commissionRate = value;
			}
		}


		// constructor
		public CommissionEmployee(int id, string name, double grossSales, double commissionRate)
		{
			Id = id;
			Name = name;
			GrossSales = grossSales;
			CommissionRate = commissionRate;
		}


		// calculate the commission employee's pay
		public double Earnings()
		{
			return GrossSales * CommissionRate;
		}

		
		// return string representation of CommissionEmployee object
		public override string ToString()
		{
			return $"EmployeeId: {Id}" +
				$"\nName: {Name}" +
				$"\nGross Sales: {GrossSales:C}" +
				$"\nCommission Rate: {CommissionRate:P}";
		}
	}
}
