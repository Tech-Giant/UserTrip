using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TripManagement.DAL.Models;

namespace TripManagement.SharedInfra.IRepository
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
