using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace Thisney.Ticket.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "API rodando. Para executar o frontend, navegue para a pasta SPA e execute o comando `ng serve`" };
        }

    }
}
