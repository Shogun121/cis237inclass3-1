using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmployeeLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary.Tests
{
    [TestClass()]
    public class SalaryEmployeeTests
    {
        [TestMethod()]
        public void NameAndSalaryTest()
        {
            //Arange
            SalaryEmployee salaryEMployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            string expected = "David Barnes $250.00";

            //ACt
            string actual = salaryEMployee.NameAndSalary();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void ToStringTest()
        {
            //Arange
            SalaryEmployee salaryEMployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            string expected = "David Barnes 250";

            //ACt
            string actual = salaryEMployee.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetYearlySalaryTest()
        {
            //Arange
            SalaryEmployee salaryEMployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            decimal expected = 13000m;

            //Act
            decimal actual = salaryEMployee.GetYearlySalary();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SalaryEmployeeTest()
        {
            //Arange
            string expectedFirstName = "David";
            string expectedLastName = "Barnes";
            DateTime expectedDateTime = new DateTime(2016,10,10);
            decimal expectedWeeklySalary = 250m;


            //Act
            SalaryEmployee salaryEMployee = new SalaryEmployee("David", "Barnes", new DateTime(2016, 10, 10), 250m);
            

            //Assert
            Assert.AreEqual(expectedFirstName,salaryEMployee.FirstName);
            Assert.AreEqual(expectedLastName, salaryEMployee.LastName);
            Assert.AreEqual(expectedDateTime, salaryEMployee.StartDate);
            Assert.AreEqual(expectedWeeklySalary, salaryEMployee.WeeklySalary);
        }
    }
}