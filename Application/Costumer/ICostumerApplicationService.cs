using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Domain;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Costumer
{
    public interface ICostumerApplicationService
    {
        Task<CostumerModel> GetByIdAsync(int id);
        Task<IEnumerable<CostumerModel>> GetAllAsync();
    }
}
