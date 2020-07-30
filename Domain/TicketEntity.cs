using System;

namespace Thisney.Ticket.Domain
{
    public class TicketEntity
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? CostumerId { get; set; }
        public CostumerEntity Costumer { get; set; }
        public EventEntity Event { get; set; }
    }
}
