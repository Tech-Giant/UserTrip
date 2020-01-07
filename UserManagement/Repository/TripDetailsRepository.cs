using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.Models;

namespace TripManagement.Repository
{
    public class TripDetailsRepository : ITripDetailsRepository
    {
        public Task<int> CreateTrip(TripDetails trip)
        {
            throw new NotImplementedException();
        }

        public Task DeleteTrip(TripDetails trip)
        {
            throw new NotImplementedException();
        }

        public Task GetTrip(TripDetails trip)
        {
            throw new NotImplementedException();
        }

        public Task<List<TripDetails>> GetTrips()
        {
            throw new NotImplementedException();
        }

        public Task UpdateTrip(TripDetails trip)
        {
            throw new NotImplementedException();
        }
    }
}
