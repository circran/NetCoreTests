using Employees.Api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Api.Data
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public readonly DataContext _context;
        public EmployeeRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<List<Employee>> GetAll()
        {
            return await _context.Employees.ToListAsync();
        }
    }
}
