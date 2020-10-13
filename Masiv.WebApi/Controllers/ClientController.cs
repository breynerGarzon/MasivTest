using Masiv.Business.Interfaces;
using Masiv.Model.Models;
using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        private readonly IClientBusinessServices ClientServies;
        public ClientController(IClientBusinessServices clientServies)
        {
            this.ClientServies = clientServies;

        }

        [HttpPost("Create")]
        public IActionResult CreateClient([FromBody] Client dataClient)
        {
            return Ok(ClientServies.CreateClient(dataClient));
        }

        [HttpPost("Update")]
        public IActionResult UpdateClient() { return Ok(); }

        [HttpPost("Delete")]
        public IActionResult DeleteClient() { return Ok(); }

        [HttpGet("Clients")]
        public IActionResult GetClient()
        {
            return Ok(ClientServies.GetClients());
        }
    }
}