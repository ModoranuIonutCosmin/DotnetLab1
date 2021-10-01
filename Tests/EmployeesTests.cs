using DotNetLab1;
using System;
using Xunit;

namespace Tests
{
    public class EmployeesTests
    {
        [Fact]
        public void EmployeeIsActiveDuringStartAndEndInterval()
        {
            //virtual permite asta, puteam pur si simplu 
            //sa instantiem clasele derivate arhitect sau manager daca era cu abstract
            //si testam pe ele la fel
            var employee = new Employee
            {
                EndDate = DateTime.Now.AddDays(1),
                StartDate = DateTime.Now.AddHours(-1)
            };

            Assert.True(employee.IsActive);
        }


        [Fact]
        public void EmployeeIsActiveOutsideStartAndEndInterval()
        {
            var employee = new Employee
            {
                EndDate = DateTime.Now.AddDays(1),
                StartDate = DateTime.Now.AddHours(1)
            };

            Assert.False(employee.IsActive);
        }

        [Fact]
        public void EmployeeIsActiveOutsideEndIntervalNow()
        {
            var employee = new Employee
            {
                EndDate = DateTime.Now,
                StartDate = DateTime.Now.AddHours(-1)
            };

            Assert.False(employee.IsActive);
        }

        [Fact]
        public void EmployeeIsActiveInsideStartIntervalNow()
        {
            var employee = new Employee
            {
                StartDate = DateTime.Now,
                EndDate = DateTime.Now.AddDays(1),
            };

            Assert.True(employee.IsActive);
        }
    }
}
