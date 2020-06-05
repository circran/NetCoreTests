using Employees.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Api.Data
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAll();
    }
}
