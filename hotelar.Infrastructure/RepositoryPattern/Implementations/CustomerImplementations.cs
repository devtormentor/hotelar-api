using hotelar.Domain.DTOs;
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
                .Include(p => p.Person)
                .ThenInclude(p => p.PersonContact)
                .ToListAsync();
        }

        public async Task CreateCustomer(CustomerDTO customer)
        {
            var newCustomer = new Customer{
                IsHosted = customer.IsHosted,
                CreatedAt = DateTime.Now,
                Person = new Person{
                    DocIdtype = customer.DocIdtype,
                    DocIdNumber = customer.DocIdNumber,
                    FullName = customer.FullName,
                    BirthDate = customer.BirthDate,
                    //relacionamento com contacto
                    PersonContact = new PersonContact{
                        FaxNumber = customer.FaxNumber,
                        ModileNumber = customer.MobileNumber,
                        PhoneNumber = customer.PhoneNumber,
                        EmailAddress = customer.EmailAddress,
                        CreatedAt = DateTime.Now
                    },
                    Address = new PersonAddress{
                        ProvinceName = customer.ProvinceName,
                        SquareName = customer.SquareName,
                        NeighborNamr = customer.NeighborName,
                        StreetName = customer.StreetName,
                        HouseNumber = customer.HouseNumber,
                        CreatedAt = DateTime.Now
                    }
                }
            };
            await context.AddRangeAsync(newCustomer);
            await context.SaveChangesAsync();
        }

        public async Task DeleteCustomer(Customer customer)
        {
            context.RemoveRange(customer);
            await context.SaveChangesAsync();
            
        }

        public async Task<Customer> GetCustomerById(int id)
        {
            var customerFounded = await context.Tb_Customer.FindAsync(id);

            return customerFounded;
        }

        

        public Task UpdateCustomer(Customer customer, int id)
        {
            throw new NotImplementedException();
        }
    }
}