using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;

namespace hotelar.Application.RepositoryPattern.Contracts
{
    public interface IEmployeeContractApp
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployee(int id);
        Task AddEmployee(EmployeeDTO Employee);
        //Task DeleteEmployee(int id);
    }
}