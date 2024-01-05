using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.Entities;

namespace hotelar.Infrastructure.RepositoryPattern.Contracts
{
    public interface ICustomerContracts
    {
        Task<IEnumerable<Customer>> GetCustomers();
        Task<Customer> GetCustomerById();
        Task CreateCustomer(Customer customer);
        Task UpdateCustomer(Customer customer, int id);
        Task DeleteCustomer(int id);
    }
}