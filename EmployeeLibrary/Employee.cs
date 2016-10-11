using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{   //decalres as abstract and gives a good base to derived classes but cannot be instantiated.
    public abstract class Employee : IEmployee
    {
        //Variables
        protected string _firstName;
        protected string _lastName;
        protected DateTime _startDate;

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        public DateTime StartDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }
        //Methods
        public override string ToString()
        {
            return _firstName + " " + LastName;
        }
        public int GetEmployementDurationInYears()
        {
            //Subtract the ticks of the start date from today, and then get the days and divide it by 365.
            return new TimeSpan(DateTime.Now.Ticks - this._startDate.Ticks).Days / 365;
        }
        //Take all of the properties for the employee and concat them together.
        public virtual string GetAllEmploymentInformation()
        {
            return this._firstName + " " + this._lastName + " " + this.GetEmployementDurationInYears();
        }
        //Get the yearly salary of the employee
        //Make the method abstract because we want the sub classes to implement it, but at this level we don't know how to implement.
        public abstract decimal GetYearlySalary();
        //COnstructors
        public Employee(string FirstName, string LastName, DateTime StartDate)
        {
            this._firstName = FirstName;
            this._lastName = LastName;
            this._startDate = StartDate;
        }
        public Employee() { }


    }
}
