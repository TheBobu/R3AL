using Microsoft.AspNetCore.Mvc;
using R3AL.Common.Enums;
using R3AL.Core.Manager.Interfaces;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationManager authenticationManager;

        public LoginController(IAuthenticationManager authenticationManager)
        {
            this.authenticationManager = authenticationManager;
        }

        [HttpPost("Authenticate")]
        public ActionResult<LoginResultDto> Authenticate([FromBody]LoginDto login)
        {
            var result = authenticationManager.Login(login.Username, login.Password);
            return result;
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
        public ActionResult<UserDto>Register([FromBody]User user)
        {
            return authenticationManager.Register(user);
        }

    }
}