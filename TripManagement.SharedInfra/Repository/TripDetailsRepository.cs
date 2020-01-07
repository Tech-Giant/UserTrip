using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TripManagement.DAL.Models;
using TripManagement.SharedInfra.IRepository;

namespace TripManagement.SharedInfra.Repository
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
