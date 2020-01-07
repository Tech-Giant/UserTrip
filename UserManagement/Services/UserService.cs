using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TripManagement.DAL.Models;
using TripManagement.SharedInfra;
using TripManagement.SharedInfra.IRepository;
using TripManagement.SharedInfra.IServices;

namespace TripManagement.Services
{
    public class UserService : IUserService
    {
        private IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ServiceResponse<List<User>>> GetUsers()
        {
            ServiceResponse<List<User>> serviceResponse = new ServiceResponse<List<User>>
            {
                ResponseStatus = ResponseStatus.NotFound
            };
            try
            {
                var users = await _userRepository.GetUsers();
                serviceResponse.Result = users;
                serviceResponse.ResponseStatus = ResponseStatus.Success;
                return serviceResponse;
            }
            catch (Exception)
            {
                serviceResponse.ResponseStatus = ResponseStatus.BadRequest;
                //Log Error
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<Guid>> AddUser(User user)
        {
            ServiceResponse<Guid> serviceResponse = new ServiceResponse<Guid>
            {
                ResponseStatus = ResponseStatus.NotFound
            };
            try
            {
                //var users = await _userRepository.GetUsers();
                //if (users != null)
                //{
                //    return users;
                //}

                //return null;
            }
            catch (Exception)
            {
                //Log Error
            }
            return serviceResponse;
        }
    }
}
