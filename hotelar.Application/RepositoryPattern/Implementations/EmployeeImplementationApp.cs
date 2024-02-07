using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.RepositoryPattern.Contracts;

namespace hotelar.Application.RepositoryPattern.Implementations
{
    public class EmployeeImplementationApp(IEmployeeContracts employeeContracts) : IEmployeeContractApp
    {
        private readonly IEmployeeContracts customerContracts = employeeContracts;

        public async Task AddEmployee(EmployeeDTO employee)
        {
            try
            {
                if (employee.DocIdNumber == string.Empty)
                {
                    throw new NullReferenceException("O numero do documento de identificação é obrigatorio");
                }
                if (employee.EmailAddress == string.Empty)
                {
                    throw new NullReferenceException("O endereço de email é obrigatorio");
                }
                if (employee.FullName == string.Empty)
                {
                    throw new NullReferenceException("O nome do cliente é obrigatorio");
                }

                await employeeContracts.CreateEmployee(employee);


            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        //public async Task DeleteEmployee(int id)
        //{
        //    var employee = await this.GetEmployee(id);
        //    await employeeContracts.DeleteEmployee(employee);
        //}

        public async Task<Employee> GetEmployee(int id)
        {
            var employee = await employeeContracts.GetEmployeeById(id);
            return employee;
        }

        public async Task<IEnumerable<Employee>> GetEmployees()
        {
            try
            {
                var employees = employeeContracts.GetEmployees();
                if (employees == null)
                {
                    return null;
                }
                return await employees;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}