using System.Collections.Generic;
using System.Linq;

namespace Thisney.Ticket.Domain
{
    public class EventEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaxPeopleCapacity { get; set; }

        public IEnumerable<TicketEntity> Ticket { get; set; }

        public EventEntity()
        {
            Ticket = new TicketEntity[0];
        }
    }
}
