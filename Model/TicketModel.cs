using System;

namespace Thisney.Ticket.Model
{
    public class TicketModel
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime? SaleDate { get; set; }
        public int? CostumerId { get; set; }
        public CostumerModel Costumer { get; set; }
        public EventModel Event { get; set; }
    }
}
