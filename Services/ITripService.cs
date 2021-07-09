using System.Collections.Generic;
using TrIpsNew.Data.Models;

namespace TrIpsNew.Services
{
    public interface ITripService
    {
         List<Trip> GetAllTrips();
         Trip GetTripByID(int tripId);
         void UpdateTrip(int tripId,Trip trip);
         void DeleteTrip(int tripId);
         void AddTrip(Trip trip);
    }
}