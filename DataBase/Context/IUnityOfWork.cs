using System.Threading.Tasks;

namespace Thisney.Ticket.Database.Context
{
    public interface IUnityOfWork
    {
        Task<int> SaveChangesAsync();
    }
}
