using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Event
{
    public class EventEntityConfiguration : IEntityTypeConfiguration<EventEntity>
    {
        public void Configure(EntityTypeBuilder<EventEntity> builder)
        {
            builder
                .ToTable("Event", "dbo");

            builder
                .HasKey(x => x.Id)
                .HasName("PK_Event");

            builder
                .Property(x => x.Id)
                .HasColumnType("INT")
                .IsRequired(true)
                .ValueGeneratedOnAdd();

            builder
                .Property(x => x.Title)
                .HasColumnType("VARCHAR(200)")
                .IsRequired(true)
                .HasMaxLength(200);

        }
    }
}
