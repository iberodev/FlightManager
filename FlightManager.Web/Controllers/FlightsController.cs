using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlightManager.Web.Services.FlightServices;
using FlightManager.Web.Model;

namespace FlightManager.Web.Controllers
{
    [Route("api/[controller]")]
    public class FlightsController : Controller
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            _flightService = flightService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAllFlightsAsync()
        {
            var flights = await _flightService.GetFlightsAsync();
            return Ok(flights);
        }

        [HttpPost("")]
        public async Task<IActionResult> AddFlightAsync([FromBody]FlightNew flight)
        {
            if (ModelState.IsValid)
            {
                await _flightService.AddFlightAsync(flight);
                return Accepted();
            }
            return BadRequest(ModelState);
        }
    }
}
