using Masiv.Business.Interfaces;
using Masiv.Model.Views;
using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BetController : ControllerBase
    {
        private readonly IBetBusinessServices BetServices;
        public BetController(IBetBusinessServices BetServices)
        {
            this.BetServices = BetServices;
        }

        [HttpPost("Create")]
        public IActionResult CreateBet([FromHeader] string idClient, [FromBody] ViewBetRequest newBet)
        {
            return Ok(this.BetServices.CreateBet(newBet, idClient));
        }
    }
}