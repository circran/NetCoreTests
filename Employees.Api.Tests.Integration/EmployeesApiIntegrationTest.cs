using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace Employees.Api.Tests.Integration
{
    public class EmployeesApiIntegrationTest
    {

        #region FluentAssertion
        [Fact]
        public async Task Get_All_Employees_FluentAssertion_Example()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/employee");

                response.EnsureSuccessStatusCode().StatusCode.Should().Be(HttpStatusCode.OK);
            }
        }

        #endregion

        [Fact]
        public async Task Get_All_Employees()
        {
            using (var client = new TestClientProvider().Client)
            {
                var response = await client.GetAsync("/api/employee");

                response.EnsureSuccessStatusCode();

                Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            }
        }
    }
}
