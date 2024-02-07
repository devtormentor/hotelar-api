using System.Net.Http.Headers;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.DataBase;
using hotelar.Infrastructure.RepositoryPattern.Contracts;
using Microsoft.EntityFrameworkCore;

namespace hotelar.Infrastructure.RepositoryPattern.Implementations
{
    public class EmployeeImplementations(DataContext context) : IEmployeeContracts
    {
        private readonly DataContext context = context;

        public Task CreateEmployee(EmployeeDTO employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetEmployeeById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            var employees = await this.context.Tb_Employee.ToListAsync();
            return employees;
        }

        public Task UpdateEmployee(EmployeeDTO employee, int id)
        {
            throw new NotImplementedException();
        }
    }
}