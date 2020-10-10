using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    public class BetController : ControllerBase
    {
        public BetController()
        {

        }

        [HttpPost("Create")]
        public IActionResult CreateBet([FromHeader] string idUsuario,
        [FromBody] ApuestaSolicitud solicitudNuevaApuesta)
        {
            return Ok();
        }
    }
}