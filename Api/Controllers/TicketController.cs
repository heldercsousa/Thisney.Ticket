using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thisney.Ticket.Application.Ticket;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        private readonly ITicketApplicationService _ticketService;

        public TicketController(ITicketApplicationService ticketService)
        {
            _ticketService = ticketService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TicketModel>>> GetAllAsync()
        {
            return Ok(await _ticketService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TicketModel>> GetByIdAsync(int id)
        {
            return Ok(await _ticketService.GetByIdAsync(id));
        }
    }
}
