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
    }
}