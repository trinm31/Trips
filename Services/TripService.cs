using System.Linq;
using System.Collections.Generic;
using TrIpsNew.Data.Models;
using TrIpsNew.Data;
using TrIpsNew.Services;


namespace TrIpsNew.Services
{
    public class TripService : ITripService
    {
        public void AddTrip(Trip trip)
        {
            TrIpsNew.Data.Data.Trips.Add(trip);
        }

        public void DeleteTrip(int tripId)
        {
            var trip = TrIpsNew.Data.Data.Trips.FirstOrDefault(t=> t.Id == tripId);
            if (trip != null){
                TrIpsNew.Data.Data.Trips.Remove(trip);
            }
        }

        public List<Trip> GetAllTrips()
        {
            return TrIpsNew.Data.Data.Trips.ToList();
        }

        public Trip GetTripByID(int tripId)
        {
            return TrIpsNew.Data.Data.Trips.FirstOrDefault(t=> t.Id == tripId);
        }

        public void UpdateTrip(int tripId, Trip trip)
        {
            var oldTrip = TrIpsNew.Data.Data.Trips.FirstOrDefault(n=> n.Id == tripId);
            if(oldTrip != null)
            {
                oldTrip.Name = trip.Name;
                oldTrip.Description = trip.Description;
                oldTrip.DateStarted = oldTrip.DateStarted;
                oldTrip.DateCompleted = oldTrip.DateCompleted;
            }
        }
    }
}