using System.Linq;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Event
{
    public class EventRepository : IRepository<EventEntity>
    {
        private readonly Context _context;

        public EventRepository(Context context)
        {
            _context = context;
        }

        public async Task<IQueryable<EventEntity>> GetAllAsync(string[] include = null)
        {
            await Task.Yield();
            var r = _context.Event.AsQueryable();
            return r;
        }

        public async Task<EventEntity> GetByIdAsync(int id, string[] include = null)
        {
            var r = await _context.Event.FindAsync(id);
            return r;
        }
    }
}
