using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TripManagement.DAL.Models;

namespace TripManagement.SharedInfra.IServices
{
    public interface IUserService
    {
        Task<ServiceResponse<List<User>>> GetUsers();

        Task<ServiceResponse<Guid>> AddUser(User user);
    }
}
