using Microsoft.AspNetCore.Mvc;
using R3AL.Common.Enums;
using R3AL.Core.Manager.Interfaces;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginApiController : ControllerBase
    {
        private readonly IAuthenticationManager authenticationManager;

        public LoginApiController(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }

        [HttpPost("Authenticate")]
        public ActionResult<LoginResultDto> Authenticate(string username, string password)
        {
            var result = authenticationManager.Login(username, password);
            if (result.LoginResult == Result.UserNotFound)
                return new NotFoundResult();
            return RedirectToAction("GetUser", result.User.UserId);
        }

        [HttpGet("{id}")]
        public ActionResult<UserDto> GetUser([FromRoute]int id)
        {
            return authenticationManager.GetUser(id);
        }

        [HttpGet("{id}/Extended")]
        public ActionResult<UserExtendedDto> GetUserExtended([FromRoute] int id)
        {
            return authenticationManager.GetUserExtended(id);
        }

        [HttpGet]
        public string Get()
        {
            return "test";
        }

        [HttpPost("Register")]
        public ActionResult<UserDto>Register(User user)
        {
            return authenticationManager.Register(user);
        }

    }
}