using Masiv.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RouletteController : ControllerBase
    {
        private readonly IRouletteBusinessServices RouletteServices;
        public RouletteController(IRouletteBusinessServices rouletteServices)
        {
            this.RouletteServices = rouletteServices;
        }

        [HttpPost("Create")]
        public IActionResult CreateRoulette()
        {
            return Ok(this.RouletteServices.CreateRoulette());
        }

        [HttpPut("Open/{rouletteId:int}")]
        public IActionResult OpenRoulette(int rouletteId)
        {
            return Ok(this.RouletteServices.EnableRoulette(rouletteId));
        }

        [HttpPut("Close/{rouletteId:int}")]
        public IActionResult CloseRoulette(int rouletteId)
        {
            return Ok(this.RouletteServices.DisableRoulette(rouletteId));
        }

        [HttpGet("Roulettes")]
        public IActionResult GetRoulettes()
        {
            return Ok(this.RouletteServices.GetRoulettes());
        }
    }
}