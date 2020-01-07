using System.Collections.Generic;
using System.Threading.Tasks;
using TripManagement.DAL.Models;

namespace TripManagement.SharedInfra.IRepository
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
