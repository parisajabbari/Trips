
using System.Collections.Generic;

namespace TripPlanner.Data
{
    public interface ITripServices
    {
        List<Trip> GetAllTrips();
        Trip GetTripById(int tripId);
        void updateTrip(int tripId, Trip trip);
        void DeleteTrip(int tripId);
        void AddTrip(Trip trip);
    }
}