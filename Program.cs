using System;

namespace InheritanceExample
{
    class Program
    {
        static void Main(string[] args)
        {
            CommissionEmployee commEmp = new CommissionEmployee(101, "John", 10000, 0.12);

            Console.WriteLine("Commission Employee's Info\n");
            Console.WriteLine(commEmp);
            Console.WriteLine($"\nEarnings: {commEmp.Earnings():C}");



            SalaryPlusCommissionEmployee salCommEmp = new SalaryPlusCommissionEmployee(102, "Anna", 10000, 0.08, 500);

            Console.WriteLine("\n\nSalary Plus Commission Employee's Info\n");
            Console.WriteLine(salCommEmp);
            Console.WriteLine($"\nEarnings: {salCommEmp.Earnings():C}");
        }
    }
}
