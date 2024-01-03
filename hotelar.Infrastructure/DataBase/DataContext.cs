using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace hotelar.Infrastructure.DataBase
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> contextOptions) : base(contextOptions)
        {
            
        }

        public DbSet<Person> Tb_Person {get; set;}
        public DbSet<Customer> Tb_Customer {get; set;}
        public DbSet<Room> Tb_Room {get; set;}
        public DbSet<RoomService> Tb_RoomService {get; set;}
        public DbSet<Employee> Tb_Employee {get; set;}
        public DbSet<ServiceScheduling> Tb_ServiceScheduling {get; set;}
    }
}