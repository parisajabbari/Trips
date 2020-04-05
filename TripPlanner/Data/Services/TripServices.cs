using System.Collections.Generic;
using System.Linq;

namespace TripPlanner.Data
{
    public class TripServices : ITripServices
    {
        public void AddTrip(Trip trip)
        {
            Data.Trips.Add(trip);
        }

        public void DeleteTrip(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public List<Trip> GetAllTrips() => Data.Trips.ToList();

        public Trip GetTripById(int tripId)
        {
            throw new System.NotImplementedException();
        }

        public void updateTrip(int tripId, Trip trip)
        {
            throw new System.NotImplementedException();
        }
    }
}