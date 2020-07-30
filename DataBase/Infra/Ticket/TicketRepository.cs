using System.Linq;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Ticket
{
    public class TicketRepository : IRepository<TicketEntity>
    {
        private readonly Context _context;

        public TicketRepository(Context context)
        {
            _context = context;
        }

        public async Task<IQueryable<TicketEntity>> GetAllAsync(string[] include = null)
        {
            await Task.Yield();
            var r = _context.Ticket.AsQueryable();
            return r;
        }

        public async Task<TicketEntity> GetByIdAsync(int id, string[] include = null)
        {
            var r = await _context.Ticket.FindAsync(id);
            return r;
        }
    }
}
