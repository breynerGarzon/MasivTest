using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientController : ControllerBase
    {
        public ClientController()
        {

        }
        
        [HttpPost("Create")]
        public IActionResult CreateClient() { return Ok(); }

        [HttpPost("Update")]
        public IActionResult UpdateClient() { return Ok(); }

        [HttpPost("Delete")]
        public IActionResult DeleteClient() { return Ok(); }

        [HttpPost("Clients")]
        public IActionResult GetClient() { return Ok(); }
    }
}