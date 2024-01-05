using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotelar.Infrastructure.Config;

public class CustomerConfig : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {   
        builder
            .HasOne(p => p.Person)
            .WithMany(c => c.Customers)
            .OnDelete(DeleteBehavior.Cascade);
    }
}