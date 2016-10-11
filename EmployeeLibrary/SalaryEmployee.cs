using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class SalaryEmployee : Employee
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
        public override string ToString()
        {
            //Take the string th eparent's ToString will return, and concat the weekly salary to it.
            //Muse use the keyword 'base' if trying to access the parent's version of the method.
            return base.ToString() + " " + this._weeklySalary; ;
        }
        public override string GetAllEmploymentInformation()
        {
            return base.GetAllEmploymentInformation() + " " + this._weeklySalary;
        }
        //OVerride the abstract method in the Employee class.
        //Because the employee class declares the method as abstract, this class MUST implement it.
        public override decimal GetYearlySalary()
        {
            return this._weeklySalary * 52;
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
