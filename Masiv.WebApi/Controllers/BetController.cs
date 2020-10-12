using Masiv.Business.Interfaces;
using Masiv.Model.Views;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Masiv.WebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BetController : ControllerBase
    {
        private readonly IBetBusinessServices BetServices;
        private readonly IDiagnosticContext DiagnosticContext;
        public BetController(IBetBusinessServices BetServices, IDiagnosticContext diagnosticContext)
        {
            this.DiagnosticContext = diagnosticContext;
            this.BetServices = BetServices;
        }

        [HttpPost("Create")]
        public IActionResult CreateBet([FromHeader] string idClient, [FromBody] ViewBetRequest newBet)
        {
            // this.DiagnosticContext.Set("CatalogLoadTime", 1423);
            Log.Information("Starting web host");

            return Ok(this.BetServices.CreateBet(newBet, idClient));
        }
    }
}