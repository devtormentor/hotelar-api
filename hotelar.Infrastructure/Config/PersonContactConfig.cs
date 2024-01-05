using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotelar.Infrastructure.Config
{
    public class PersonContactConfig : IEntityTypeConfiguration<PersonContact>
    {
        public void Configure(EntityTypeBuilder<PersonContact> builder)
        {
            builder
                .HasOne(p => p.Person)
                .WithOne(p => p.PersonContact);
                //.HasForeignKey("Tb_PersonContact", "PersonId");
        }
    }
}