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

            //Decalre a new collection.
            IEmployeeCollection employeeCollection;
            //Instantiate the collection with the concrete class even though it is going into an interface container.
            employeeCollection = new EmployeeCollection();
            //Call the method below to add the employees to the collection.
            AddNewEmployee(employeeCollection);

            PrintEmployees(employeeCollection);
        }
        static void AddNewEmployee(IEmployeeCollection employeeCollection)
        {
            //Add a couple of salaried employees.
            employeeCollection.add("James", "Kirk", new DateTime(2016, 4, 4), 549m);
            employeeCollection.add("Jean-Luc", "Picard", new DateTime(2016, 5, 14), 609m);
            //Add a couple of hourly employees.
            employeeCollection.add("Benjamin", "Sisko", new DateTime(2016, 4, 4), 49m, 40);
            employeeCollection.add("Jonathan", "Archer", new DateTime(2016, 4, 4), 54m, 20);
        } 
        static void PrintEmployees(IEmployeeCollection employeeCollection)
        {
            Console.WriteLine(employeeCollection.GetPrintString());
        }
    }
}
