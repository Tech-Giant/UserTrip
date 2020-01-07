using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using TripManagement.DAL.Models;


namespace TripManagement.SharedInfra
{
    public class BaseApiController : ControllerBase
    {
        public BaseApiController() : base()
        {
        }

        public IActionResult GetResponse<T>(ServiceResponse<T> serviceResponse)
        {
            switch (serviceResponse.ResponseStatus)
            {
                case ResponseStatus.Success:
                    return Ok(serviceResponse.Result);
                case ResponseStatus.Error:
                    return BadRequest(serviceResponse.Errors);
                case ResponseStatus.Forbidden:
                    return Forbid();
                case ResponseStatus.Conflict:
                    return Conflict(serviceResponse.Errors);
                case ResponseStatus.NotFound:
                    return NotFound(serviceResponse.Errors);
                case ResponseStatus.NoContent:
                    return NoContent();
                case ResponseStatus.Unauthorized:
                    return Unauthorized();
                case ResponseStatus.BadRequest:
                    return BadRequest(serviceResponse.Errors);
                case ResponseStatus.InternalServerError:
                default:
                    return StatusCode(500, "Common Message: An error occured, contact administrator");
            }

        }
    }
}
