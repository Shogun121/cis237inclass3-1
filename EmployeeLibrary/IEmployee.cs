using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public interface IEmployee
    {
        //Declare all the public methods and proeprties that must be implemented in child classes.
        int GetEmployementDurationInYears(); 
        string GetAllEmploymentInformation();
        decimal GetYearlySalary();      
    }
}
