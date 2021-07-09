using System;
using System.Collections.Generic;
using TrIpsNew.Data.Models;

namespace TrIpsNew.Data
{
    public static class Data
    {
        public static List<Trip> Trips => allTrips;
        static List<Trip> allTrips = new List<Trip>()
        {
            new Trip(){
                Id = 1,
                Name = "VietNam",
                Description = "Good",
                DateStarted = new DateTime(2017,01,01),
                DateCompleted = new DateTime(2017,01,01)
            },
            new Trip(){
                Id = 2,
                Name = "Laos",
                Description = "Good",
                DateStarted = new DateTime(2017,01,01),
                DateCompleted = new DateTime(2017,01,01)
            },
            new Trip(){
                Id = 3,
                Name = "Sin",
                Description = "Good",
                DateStarted = new DateTime(2017,01,01),
                DateCompleted = new DateTime(2017,01,01)
            },
            new Trip(){
                Id = 4,
                Name = "Campuchia",
                Description = "Good",
                DateStarted = new DateTime(2017,01,01),
                DateCompleted = new DateTime(2017,01,01)
            },
            new Trip(){
                Id = 5,
                Name = "ThaiLan",
                Description = "Good",
                DateStarted = new DateTime(2017,01,01),
                DateCompleted = new DateTime(2017,01,01)
            }
        };
    }
}