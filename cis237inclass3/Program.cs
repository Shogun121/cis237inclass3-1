using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class Program
    {
        static void Main(string[] args)
        {
            SalaryEmployee sEmployee = new SalaryEmployee("Robert","Cooley",new DateTime(2014,10,21),537.36m);
            SalaryEmployee sEmployee2 = new SalaryEmployee();

            //Output the SalaryEmployee converted to a string.
            Console.WriteLine(sEmployee.ToString());
            Console.WriteLine(sEmployee2.ToString());

            HourlyEmployee hEmployee = new HourlyEmployee("Joe","Smith",new DateTime(2013,10,01),12.43m,36);
            Console.WriteLine(hEmployee.ToString());
            Console.WriteLine(hEmployee.GetYearlySalary());
            Console.WriteLine(hEmployee.GetAllEmploymentInformation());
            
            
        }
    }
}
