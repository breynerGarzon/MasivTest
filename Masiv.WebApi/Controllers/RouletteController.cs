using Masiv.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller"))]
    public class RouletteController : ControllerBase
    {
        private readonly IRouletteBusinessServices RouletteServices;
        public RouletteController(IRouletteBusinessServices rouletteServices)
        {
            this.rouletteServices = rouletteServices;
        }

        [HttpPost("Create")]
        public IActionResult CreateRoulette()
        {
            try
            {
                return Created(this.RouletteServices.CreateRoulette());
            }
            catch (System.Exception ex)
            {
                return this.Problem();
            }
        }


        [HttpPost("Create")]
        public IActionResult CreateRoulette()
        {
            try
            {
                return Created(this.RouletteServices.CreateRoulette());
            }
            catch (System.Exception ex)
            {
                return this.Problem();
            }
        }

        [HttpPost("Create")]
        public IActionResult CreateRoulette()
        {
            try
            {
                return Created(this.RouletteServices.CreateRoulette());
            }
            catch (System.Exception ex)
            {
                return this.Problem();
            }
        }
    }
}