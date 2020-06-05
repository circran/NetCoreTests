using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Moq;
using Employees.Api.Data;
using Employees.Api.Controllers;
using Employees.Api.Models;
using System.Threading.Tasks;

namespace Employees.Api.Tests.Unit
{
    public class EmployeeControllerTest
    {
        IEmployeeRepository _repo;
        EmployeeController Target;
        public EmployeeControllerTest()
        {
            _repo = Mock.Of<IEmployeeRepository>();
            Target = new EmployeeController(_repo);
        }

        [Fact]
        public void Call_The_Employee_Repository()
        {
            //Arrange
            Mock.Get(_repo).Setup(r => r.GetAll()).Returns(It.IsAny<Task<List<Employee>>>());

            //Act
            var result = Target.Get();

            //Assert
            Mock.Get(_repo).Verify(re => re.GetAll(), Times.Once);

        }

        [Fact]
        public void Returns_A_List_Of_Employees()
        {
            //Arrange
            Mock.Get(_repo).Setup(r => r.GetAll()).Returns(It.IsAny<Task<List<Employee>>>());

            //Act
            var result = Target.Get();

            //Assert
            Assert.IsType<Task<IEnumerable<Employee>>>(result);
        }

    }
}
