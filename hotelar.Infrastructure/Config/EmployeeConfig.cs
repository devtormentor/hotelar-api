using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotelar.Infrastructure.Config;

public class EmployeeConfig : IEntityTypeConfiguration<Employee>
{
    public void Configure(EntityTypeBuilder<Employee> builder)
    {   
        builder
            .HasOne(p => p.Person)
            .WithMany(c => c.Employees)
            .OnDelete(DeleteBehavior.Cascade);
    }
}