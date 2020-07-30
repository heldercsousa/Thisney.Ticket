using System.Threading.Tasks;

namespace Thisney.Ticket.Database.Context
{
    public sealed class UnitOfWork : IUnityOfWork
    {
        private Context Context { get; }

        public UnitOfWork(Context context)
        {
            Context = context;
        }

        public Task<int> SaveChangesAsync()
        {
            return Context.SaveChangesAsync();
        }
    }
}
