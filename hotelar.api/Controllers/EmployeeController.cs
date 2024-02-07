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
    public class EmployeeController(IEmployeeContractApp contractApp) : ControllerBase
    {
        private readonly IEmployeeContractApp contractApp = contractApp;

        [HttpGet]
        public async Task<IActionResult> Get ()
        {
            var employees =await contractApp.GetEmployees();
            return Ok(employees);
        }
        [HttpPost]
        public async Task<IActionResult> Insert (EmployeeDTO employee)
        {
            await contractApp.AddEmployee(employee);
            return Ok("Employee Added successfully");
        }
        
        [HttpDelete]
        public async Task<IActionResult> Delete (int id)
        {
            //await contractApp.DeleteEmployee(id);
            return NoContent();
        }
    }
}