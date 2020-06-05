using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employees.Api.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{ FirstName } { LastName }";
        public int Vacation => ((this.Created.Year - DateTime.Now.Year) * 12) + this.Created.Month - this.Created.Month;
        public DateTime Created { get; set; }

        public Employee(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Created = DateTime.Now;
        }
    }
}
