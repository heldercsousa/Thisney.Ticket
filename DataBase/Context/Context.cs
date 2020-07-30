using Microsoft.EntityFrameworkCore;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.Database.Context
{
    public sealed class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }

        public DbSet<EventEntity> Event { get; set; }
        public DbSet<CostumerEntity> Costumer { get; set; }
        public DbSet<TicketEntity> Ticket { get; set; }

    }
}
