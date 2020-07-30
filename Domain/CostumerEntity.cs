using System;
using System.Collections.Generic;

namespace Thisney.Ticket.Domain
{
    public class CostumerEntity
    {
        public int Id { get; set; }
        public string CPF { get; set; }
        public string Name { get; set; }
        public IEnumerable<TicketEntity> Ticket { get; set; }

        public CostumerEntity()
        {
            Ticket = new TicketEntity[0];
        }
    }
}
