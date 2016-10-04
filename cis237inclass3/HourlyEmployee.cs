using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237inclass3
{
    class HourlyEmployee : Employee
    {
        //Variable for this class.
        private decimal _hourlyRate;
        private decimal _hoursPerWeek;

        //Properties
        //Properties don't have to be a direct relationship toa  single variable.
        //Here I am using 2 variables to get the value for a single property.
        public decimal WeeklySalary
        {
            get { return this._hourlyRate * this._hoursPerWeek; }
            set {; }
        }
        //Methods
        //OVerride the virtual method from EMployee class. I did not need to override it. I could have used parent class version.
        public override string GetAllEmploymentInformation()
        {
            return base.GetAllEmploymentInformation() + " " + this.WeeklySalary;
        }
        public override string ToString()
        {
            //Use the weekly salary property declard above to make up this ToString.
            //The same way it will return the same string as Salary Employee even though this employee is hourly.
            return base.ToString() + " " + this.WeeklySalary;
        }
        //Tmplement the abstract method declared in Employee.
        public override decimal GetYearlySalary()
        {
            return this.WeeklySalary * 52;
        }
        //Constructors
        //Take in all five parameters that make up an hourly employee. Send the first three parameters to the bease constructor since it knows how to do the assignments for me.
        //Then I just have to do the 2 remaining variables.
        public HourlyEmployee(string firstName, string lastName,DateTime startDate, decimal hourlyRate, decimal hoursPerWeek):base(firstName,lastName, startDate)
        {
            this._hourlyRate = hourlyRate;
            this._hoursPerWeek = hoursPerWeek;
        }
    }
}
