using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Application.RepositoryPattern.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace hotelar.api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController(ICustomerContractApp contractApp) : ControllerBase
    {
        private readonly ICustomerContractApp contractApp = contractApp;

        [HttpGet]
        public async Task<IActionResult> Get ()
        {
            var customers =await contractApp.GetCustomers();
            return Ok(customers);
        }
    }
}