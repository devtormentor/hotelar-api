using hotelar.Domain.Entities;
using hotelar.Infrastructure.DataBase;
using hotelar.Infrastructure.RepositoryPattern.Contracts;
using Microsoft.EntityFrameworkCore;

namespace hotelar.Infrastructure.RepositoryPattern.Implementations
{
    public class CustomerImplementations(DataContext context) : ICustomerContracts
    {
        private readonly DataContext context = context;
        // exibir todos os clientes
        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            return await context.Tb_Customer
                .ToListAsync();
        }

        public Task CreateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Task DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Customer> GetCustomerById()
        {
            throw new NotImplementedException();
        }

        

        public Task UpdateCustomer(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}