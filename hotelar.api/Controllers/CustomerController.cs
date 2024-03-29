using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.DTOs;
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
        [HttpPost]
        public async Task<IActionResult> Insert (CustomerDTO customer)
        {
            await contractApp.AddCustomer(customer);
            return Ok("Customer Added successfully");
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete (int id)
        {
            await contractApp.DeleteCustomer(id);
            return NoContent();
        }
    }
}