using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.Entities;

namespace hotelar.Application.RepositoryPattern.Contracts
{
    public interface ICustomerContractApp
    {
        Task<IEnumerable<Customer>> GetCustomers();
    }
}