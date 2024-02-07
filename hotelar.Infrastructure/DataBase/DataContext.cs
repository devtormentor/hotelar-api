using hotelar.Domain.Entities;
using hotelar.Infrastructure.Config;
using Microsoft.EntityFrameworkCore;

namespace hotelar.Infrastructure.DataBase
{
    public class DataContext(DbContextOptions<DataContext> contextOptions) : DbContext(contextOptions)
    {
        /// <summary>
        /// mapeamento das entidades para o banco de dados usando
        /// usando o dbcontext como recurso do ef core
        /// </summary>

        public DbSet<Person> Tb_Person {get; set;}
        public DbSet<Customer> Tb_Customer {get; set;}
        public DbSet<DirectSell> Tb_DirectSell {get; set;}
        public DbSet<Reservation> Tb_Reservation {get; set;}
        public DbSet<Room> Tb_Room {get; set;}
        public DbSet<Employee> Tb_Employee {get; set;}
        public DbSet<RoomService> Tb_RoomService {get; set;}
        public DbSet<PersonContact> Tb_PersonContact {get; set;}
        public DbSet<PersonAddress> Tb_PersonAddress {get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonConfig());

            base.OnModelCreating(modelBuilder);
        }
    }
}