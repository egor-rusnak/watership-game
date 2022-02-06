using BattleShip.UserAccess.WebApi.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BattleShip.UserAccess.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpPost]
        public IActionResult RegisterUser(RegisterUserRequest request)
        {
            //execute

            return Ok();
        }
    }
}
