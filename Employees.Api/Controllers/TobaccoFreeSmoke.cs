using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Employees.Api.Data;
using Employees.Api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Employees.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TobaccoFreeSmoke
    {
        [HttpGet]
        public string Get()
        {
            return "FreeSmoke";
        }
    }
}
