using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TripManagement.DAL.Models;
using TripManagement.SharedInfra;
using TripManagement.SharedInfra.IServices;

namespace TripManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : BaseApiController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> Getusers()
        {
            var serviceResponse = await _userService.GetUsers();
            return this.GetResponse(serviceResponse);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> AddUser([FromBody] User user)
        {
            var serviceResponse = await _userService.AddUser(user);
            return this.GetResponse(serviceResponse);
        }
    }
}