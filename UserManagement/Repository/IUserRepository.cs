using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.Models;

namespace TripManagement.Repository
{
    public interface IUserRepository
    {
        Task<List<User>> GetUsers();

        Task<Guid> AddUser(User user);

        Task UpdateUser(User user);

        Task DeleteUser(User user);

        Task GetUser(Guid user);
    }
}
