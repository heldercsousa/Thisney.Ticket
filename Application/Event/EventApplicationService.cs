using System.Collections.Generic;
using System.Threading.Tasks;
using Thisney.Ticket.Database.Context;
using Thisney.Ticket.DataBase.Infra;
using Thisney.Ticket.Domain;
using Thisney.Ticket.Mapping;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Application.Event
{
    public class EventApplicationService : IEventApplicationService
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IRepository<EventEntity> _eventRepository;

        public EventApplicationService(IUnityOfWork unityOfWork,
            IRepository<EventEntity> ticketRepository)
        {
            _unityOfWork = unityOfWork;
            _eventRepository = ticketRepository;
        }

        public async Task<IEnumerable<EventModel>> GetAllAsync()
        {
            var eventEntity = await _eventRepository.GetAllAsync();
            IEnumerable<EventModel> eventModel = eventEntity?.Project<EventEntity, EventModel>();
            return eventModel;
        }

        public async Task<EventModel> GetByIdAsync(int id)
        {
            var ticketEntity = await _eventRepository.GetByIdAsync(id);
            EventModel eventModel = ticketEntity?.Project<EventEntity, EventModel>();
            return eventModel;
        }
    }
}
