using Employees.Api.Models;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Employees.Api.Tests.Unit
{
    public class EmployeeTest
    {
        #region FluentAssertion
        [Fact]
        public void Create_Employee_With_Current_Date_FluentAssertions_Example()
        {
            Employee sut = new Employee("Alan", "Carando");

            sut.Created.ToString("dd/MM/yyyy").Should().Be(DateTime.Now.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void Show_Full_Name_FluentAssertions_Example()
        {
            Employee sut = new Employee("Alan", "Carando");

            sut.FullName.Should().Be("Alan Carando");
        }

        #endregion

        [Fact]
        public void Create_Employee_With_Current_Date()
        {
            Employee sut = new Employee("Alan", "Carando");

            Assert.Equal(DateTime.Now.ToString("dd/MM/yyyy"), sut.Created.ToString("dd/MM/yyyy"));
        }

        [Fact]
        public void Show_Full_Name()
        {
            Employee sut = new Employee("Alan", "Carando");

            Assert.Equal("Alan Carando", sut.FullName);
        }
    }
}
