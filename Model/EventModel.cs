using System.Collections.Generic;

namespace Thisney.Ticket.Model
{
    public class EventModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int MaxCapacity { get; set; }

        public IEnumerable<TicketModel> Ticket { get; set; }

        public EventModel()
        {
            Ticket = new TicketModel[0];
        }
    }
}
