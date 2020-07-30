using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thisney.Ticket.Application.Event;
using Thisney.Ticket.Model;

namespace Thisney.Ticket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventController : ControllerBase
    {
        private readonly IEventApplicationService _eventService;

        public EventController(IEventApplicationService eventService)
        {
            _eventService = eventService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<EventModel>>> GetAllAsync()
        {
            return Ok(await _eventService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<EventModel>> GetByIdAsync(int id)
        {
            return Ok(await _eventService.GetByIdAsync(id));
        }
    }
}
