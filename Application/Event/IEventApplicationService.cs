using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Event
{
    public interface IEventApplicationService
    {
        Task<EventModel> GetByIdAsync(int id);
        Task<IEnumerable<EventModel>> GetAllAsync();
    }
}
