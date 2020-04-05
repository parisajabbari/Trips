using Microsoft.AspNetCore.Mvc;
using TripPlanner.Data;

namespace TripPlanner.Controllers
{
    [Route ("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripServices _services;
        public TripsController(ITripServices services)
        {
            _services = services;
        }

        [HttpPost ("Add Trip")]
        public IActionResult AddTrip([FromBody]Trip trip)
        {
            if( trip != null )
            {
                _services.AddTrip(trip);
            }

            return Ok();
        }

        [HttpGet ("[action]")]
        public IActionResult GetTrips()
        {
            var AllTrips = _services.GetAllTrips();
            return Ok(AllTrips);
        }
    }
}