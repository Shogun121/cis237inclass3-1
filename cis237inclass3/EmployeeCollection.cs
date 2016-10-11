using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeLibrary;

namespace cis237inclass3
{
    class EmployeeCollection : IEmployeeCollection
    {
        //I can instantiate this array as a EMployee type because it is an array.
        //Even though I cant instatinate a single EMployee since it is abstract, and array
        //is fine. I just have to make sure that I put non-abstract instances into it.
        IEmployee[] employees = new Employee[10];
        int currentIndex;

        //Constructor
        public EmployeeCollection()
        {

        }
        public void add(string FirstName, string LastName, DateTime StartDate, decimal Salary)
        {
            employees[currentIndex++] = new SalaryEmployee(FirstName, LastName, StartDate, Salary);
        }

        public void add(string FirstName, string LastName, DateTime StartDate, decimal HourlyRate, decimal HoursPerWeek)
        {
            employees[currentIndex++] = new HourlyEmployee(FirstName, LastName, StartDate, HourlyRate, HoursPerWeek);
        }

        public string GetPrintString()
        {
            //declare a blank string to start.
            string allOutput = "";

            //foreach employee in the collection.
            foreach(Employee employee in employees)
            {
                //So long as the employee is not null.
                if(employee!=null)
                {   //Concat the employee information.
                    allOutput += employee.ToString()+Environment.NewLine;


                    //Right into the Danger Zone, Downcast from Employee-->Salary Employee
                    //We need to check to see if the type is of SalaryEmployee
                    //Otherwise, calling the NameAddSalary Method would fail for all other types of classes.
                    //Might be useful in the fourth assignment
                    if(employee.GetType()== typeof(SalaryEmployee))
                    {
                        //This is called a downcast because we are down casting it from
                        //the type of Employee down to the type of SalaryEmployee.
                        allOutput+=((SalaryEmployee)employee).NameAndSalary()+Environment.NewLine;
                    }                   
                }
            }
            //Return the concated string.
            return allOutput;
        }
    }
}
