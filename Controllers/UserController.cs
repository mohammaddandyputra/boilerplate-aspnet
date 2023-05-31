
using boilerplate_aspnet.Models;
using boilerplate_aspnet.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using boilerplate_aspnet.Data.Context;

namespace boilerplate_aspnet.Controllers
{
    [Route("api/users")]
    [ApiController]

    public class UserController : ControllerBase
    {
        private readonly UserService _userService;

        public UserController(UserService _userService)
        {
            this._userService = _userService;
        }

        [HttpGet]
        public async Task<ActionResult> getUser()
        {
            try
            {
                return Ok(await _userService.getList());
            }
            catch (Exception error)
            {
                Console.WriteLine(error);
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }

        }
    }
}