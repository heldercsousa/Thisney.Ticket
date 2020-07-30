using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Ticket
{
    public interface ITicketApplicationService
    {
        Task<TicketModel> GetByIdAsync(int id);
        Task<IEnumerable<TicketModel>> GetAllAsync();
    }
}
