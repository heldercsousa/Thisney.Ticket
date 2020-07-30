using System.Linq;
using System.Threading.Tasks;

namespace Thisney.Ticket.DataBase.Infra
{
    public interface IRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetByIdAsync(int id, string[] include = null);
        Task<IQueryable<TEntity>> GetAllAsync(string[] include = null);
    }
}
