using NUnit.Framework;
using TripPlanner.Data;
using System.Collections.Generic;
using System;

namespace TripTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            
            
             List<Trip> Trips = new List<Trip>
            {
                new Trip(1, "sydney","Business trip", new DateTime(2020, 01, 01), new DateTime(2020, 01, 07)),
                new Trip(1, "Perth","Business trip", new DateTime(2020, 01, 01), new DateTime(2020, 01, 07)),

            };
        }

        [Test]
        public void GetAllTrips_shouldReturnAllTripsInList()
        {            
            var tripServices = new TripServices();
            List<Trip> trips = tripServices.GetAllTrips();

            Assert.AreEqual(6, trips.Count);
        }

        [Test]
        public void AddTrip_ShouldReturnTripsListWithAddedNewOne()
        {
            var tripServices = new TripServices();
            var trip = new Trip(1, "sydney","Business trip", new DateTime(2020, 01, 01), new DateTime(2020, 01, 07));

            tripServices.AddTrip(trip);

            List<Trip> trips = tripServices.GetAllTrips();
            Assert.AreEqual(7, trips.Count);
        }
    }
}