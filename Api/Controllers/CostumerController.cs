using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Thisney.Ticket.Application.Costumer;
using Thisney.Ticket.Domain;
using Thisney.Ticket.Model;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CostumerController : ControllerBase
    {
        private readonly ICostumerApplicationService _costumerService;

        public CostumerController(ICostumerApplicationService costumerService)
        {
            _costumerService = costumerService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CostumerModel>>> GetAllAsync()
        {
            return Ok(await _costumerService.GetAllAsync());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CostumerEntity>> GetByIdAsync(int id)
        {
            return Ok(await _costumerService.GetByIdAsync(id));
        }

    }
}
