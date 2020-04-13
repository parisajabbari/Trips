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

        [HttpPost("AddTrip")]
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

        [HttpGet("SingleTrip/{tripId}")]
        public IActionResult GetTripById(int tripId)
        {
            var trip = _services.GetTripById(tripId);
            return Ok(trip);
        }

        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody]Trip trip)
        {
            _services.updateTrip(id, trip);
            return Ok(trip);
        }

        [HttpDelete("DeleteTrip/{id}")]
        public IActionResult DeleteTrip(int id)
        {
            _services.DeleteTrip(id);
            return Ok();
        }
    }
}