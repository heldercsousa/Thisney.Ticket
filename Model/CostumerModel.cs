using System.Collections.Generic;

namespace Thisney.Ticket.Model
{
    public class CostumerModel
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public IEnumerable<TicketModel> Ticket { get; set; }

        public CostumerModel()
        {
            Ticket = new TicketModel[0];
        }
    }
}
