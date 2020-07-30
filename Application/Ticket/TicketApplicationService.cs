using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.DataBase.Infra;
using Thisney.Ticket.Domain;
using Thisney.Ticket.Mapping;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Ticket
{
    public class TicketApplicationService : ITicketApplicationService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IRepository<TicketEntity> _ticketRepository;

        public TicketApplicationService(IUnityOfWork unityOfWork,
            IRepository<TicketEntity> ticketRepository)
        {
            _unityOfWork = unityOfWork;
            _ticketRepository = ticketRepository;
        }

        public async Task<TicketModel> GetByIdAsync(int id)
        {
            var ticketEntity = await _ticketRepository.GetByIdAsync(id);
            TicketModel ticketModel = ticketEntity?.Project<TicketEntity, TicketModel>();
            return ticketModel;
        }

        public async Task<IEnumerable<TicketModel>> GetAllAsync()
        {
            var ticketEntities = await _ticketRepository.GetAllAsync();
            IEnumerable<TicketModel> ticketModels = ticketEntities?.Project<TicketEntity, TicketModel>();
            return ticketModels;
        }

    }
}
