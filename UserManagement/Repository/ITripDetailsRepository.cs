using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.Models;

namespace TripManagement.Repository
{
    public interface ITripDetailsRepository
    {
        Task<List<TripDetails>> GetTrips();

        Task<int> CreateTrip(TripDetails trip);

        Task UpdateTrip(TripDetails trip);

        Task DeleteTrip(TripDetails trip);

        Task GetTrip(TripDetails trip);
    }
}
