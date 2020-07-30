using System.Linq;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.Domain;

namespace Thisney.Ticket.DataBase.Infra.Costumer
{
    public class CostumerRepository : IRepository<CostumerEntity>
    {
        private readonly Context _context;

        public CostumerRepository(Context context)
        {
            _context = context;
        }

        public async Task<IQueryable<CostumerEntity>> GetAllAsync(string[] include = null)
        {
            await Task.Yield();
            var r = _context.Costumer.AsQueryable();
            return r;
        }

        public async Task<CostumerEntity> GetByIdAsync(int id, string[] include = null)
        {
            var r = await _context.Costumer.FindAsync(id);
            return r;
        }
    }
}
