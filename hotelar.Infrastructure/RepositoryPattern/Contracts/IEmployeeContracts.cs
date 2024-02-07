using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;

namespace hotelar.Infrastructure.RepositoryPattern.Contracts
{
    public interface IEmployeeContracts
    {
        Task<IEnumerable<Employee>> GetEmployees();
        Task<Employee> GetEmployeeById(int id);
        Task CreateEmployee(EmployeeDTO employee);
        Task UpdateEmployee(EmployeeDTO employee, int id);
        Task DeleteEmployee(int id);
    }
}