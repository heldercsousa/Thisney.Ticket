using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Costumer
{
    public class CostumerEntityConfiguration : IEntityTypeConfiguration<CostumerEntity>
    {
        public void Configure(EntityTypeBuilder<CostumerEntity> builder)
        {
            builder
                .ToTable("Costumer", "dbo");

            builder
                .HasKey(x => x.Id)
                .HasName("PK_Costumer");

            builder
                .Property(x => x.Id)
                .HasColumnType("INT")
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.CPF)
                .HasColumnType("VARCHAR(11)")
                .IsRequired(true)
                .HasMaxLength(11);

            builder
                .Property(x => x.Name)
                .HasColumnType("VARCHAR(200)")
                .IsRequired(true)
                .HasMaxLength(200);
        }
    }
}
