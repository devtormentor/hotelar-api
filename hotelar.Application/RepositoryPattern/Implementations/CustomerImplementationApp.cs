using hotelar.Application.RepositoryPattern.Contracts;
using hotelar.Domain.Entities;
using hotelar.Infrastructure.RepositoryPattern.Contracts;

namespace hotelar.Application.RepositoryPattern.Implementations
{
    public class CustomerImplementationApp(ICustomerContracts customerContracts) : ICustomerContractApp
    {
        private readonly ICustomerContracts customer = customerContracts;

        public async Task<IEnumerable<Customer>> GetCustomers()
        {
            try
            {
                var customers = this.customer.GetCustomers();
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