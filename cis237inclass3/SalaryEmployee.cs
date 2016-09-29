using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class SalaryEmployee : Employee
    {
        //Variables
        private decimal _weeklySalary;

        //Properties
        public decimal WeeklySalary
        {
            get { return _weeklySalary; }
            set { _weeklySalary = value; }
        }
        //Methods
        public string NameAndSalary()
        {
            return base.ToString()+" "+_weeklySalary.ToString("C");
        }
        //Constructor
        public SalaryEmployee(string FirstName, string LastName, DateTime StartDate, decimal WeeklySalary)
            :base(FirstName, LastName, StartDate)  //Calls parent class's constructor so that we don't have to repeat the parent con. work.
        {
            _weeklySalary = WeeklySalary;
        }
        public SalaryEmployee() :base()
        {

        }
    }
}
