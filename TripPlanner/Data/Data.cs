using System;
using System.Collections.Generic;

namespace TripPlanner.Data
{
    public static class Data
{
    public static List<Trip> Trips => allTrips;
    static List<Trip> allTrips = new List<Trip>()
    {
        new Trip(1, "Vienna, Austria", "Vienna, is one the most beautiful cities in Austria", new DateTime(2017,01,20), null ),
        new Trip(2, "Carpinteria, CA, USA", "Carpinteria is a city located on the central coast of California", new DateTime(2019,02,22), new DateTime(2019,01,30) ),
        new Trip(3,"San Francisco, CA, USA", "San Francisco is a metropolitan area located on the west coast of the United States.",new DateTime(2019,01,27), new DateTime(2019,01,30)),
        new Trip(4,"Tucson, AZ, USA", "Tucson is a southwestern city in Arizona that is home to the University of Arizona",new DateTime(2019,01,20), null  ),
        new Trip(5, "Albuquerque, NM, USA", "Albuquerque is a city located in New Mexico that is famous for its balloon festivals", new DateTime(2015,01,20), new DateTime(2015,01,30)  ),
        new Trip(7,"Munich, Germany","Munich is an important city in Germany, located in the heart of Bavaria.", new DateTime(2019,01,20), null )
    };

}
}