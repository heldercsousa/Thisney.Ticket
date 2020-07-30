using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Ticket
{
    public class TicketEntityConfiguration : IEntityTypeConfiguration<TicketEntity>
    {
        public void Configure(EntityTypeBuilder<TicketEntity> builder)
        {
            builder
                .ToTable("Ticket", "dbo");

            builder
                .HasKey(x => x.Id)
                .HasName("PK_Ticket");

            builder
                .Property(x => x.Id)
                .HasColumnType("INT")
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.EventId)
                .HasColumnType("INT")
                .IsRequired(true);

            builder
                .Property(x => x.ShippingDate)
                .HasColumnType("DATETIME")
                .IsRequired(true);

            builder
                .Property(x => x.SaleDate)
                .HasColumnType("DATETIME")
                .IsRequired(false);

            builder
                .Property(x => x.CostumerId)
                .HasColumnType("INT")
                .IsRequired(false);

            builder
                .HasOne(x => x.Costumer)
                .WithMany(x => x.Ticket)
                .HasForeignKey(x => x.CostumerId)
                .HasConstraintName("FK_Ticket_Costumer");

            builder
                .HasOne(x => x.Event)
                .WithMany(x => x.Ticket)
                .HasForeignKey(x => x.EventId)
                .HasConstraintName("FK_Ticket_Event");
        }
    }
}