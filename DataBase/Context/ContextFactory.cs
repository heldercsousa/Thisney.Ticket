using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Thisney.Ticket.Database.Context
{
    public sealed class ContextFactory : IDesignTimeDbContextFactory<Context>
    {
        public Context CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<Context>();

            builder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=ThisneyTicket;Trusted_Connection=True;");

            return new Context(builder.Options);
        }
    }
}
