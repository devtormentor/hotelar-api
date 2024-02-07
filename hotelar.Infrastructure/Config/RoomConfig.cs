using hotelar.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace hotelar.Infrastructure.Config;

public class RoomConfig : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {   
       // builder
           // .HasOne(p => p.Person)
           // .WithMany(c => c.Customers)
           // .OnDelete(DeleteBehavior.Cascade);
            //nao posso deletar um quarto com um cliente hospedado nele
    }
}