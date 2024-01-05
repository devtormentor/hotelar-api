using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotelar.Infrastructure.Config
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder
                .HasKey(k => k.Id);
            
            builder
                .HasOne(p => p.PersonContact)
                .WithOne(p => p.Person)
                .HasForeignKey("Person", "ContactId");
        }
    }
}