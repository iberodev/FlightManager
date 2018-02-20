using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlightManager.Web.Services.AirportServices;

namespace FlightManager.Web.Controllers
{
    [Route("[controller]")]
    public class AirportsController : Controller
    {
        private readonly IAirportService _airportService;

        public AirportsController(IAirportService airportService)
        {
            _airportService = airportService;
        }

        [HttpGet("")]
        public async Task<IActionResult> GetAirportsAsync()
        {
            var airports = await _airportService.GetAirportsAsync();
            return Ok(airports);
        }
    }
}
