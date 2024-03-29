using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.DTOs;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.RepositoryPattern.Contracts;

namespace hotelar.Application.RepositoryPattern.Implementations
{
    public class CustomerImplementationApp(ICustomerContracts customerContracts) : ICustomerContractApp
    {
        private readonly ICustomerContracts customerContracts = customerContracts;

        public async Task AddCustomer(CustomerDTO customer)
        {
            try
            {
                if (customer.DocIdNumber == string.Empty)
                {
                    throw new NullReferenceException("O numero do documento de identificação é obrigatorio");
                }
                if (customer.EmailAddress == string.Empty)
                {
                    throw new NullReferenceException("O endereço de email é obrigatorio");
                }
                if (customer.FullName == string.Empty)
                {
                    throw new NullReferenceException("O nome do cliente é obrigatorio");
                }

                await customerContracts.CreateCustomer(customer);


            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task DeleteCustomer(int id)
        {
            var customer = await customerContracts.GetCustomerById(id);
            await customerContracts.DeleteCustomer(customer);
        }

        public async Task<Customer> GetCustomer(int id)
        {
            var customer = await customerContracts.GetCustomerById(id);
            return customer;
        }

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            try
            {
                var customers = this.customerContracts.GetCustomers();
                if (customers == null)
                {
                    return null;
                }
                return await customers;
            }
            catch (System.Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}