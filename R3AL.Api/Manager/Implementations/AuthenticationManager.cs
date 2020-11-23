using R3AL.Common.Enums;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Implementations
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IUserService userService;

        public AuthenticationManager(IUserService userService)
        {
            this.userService = userService;
        }

        public LoginResultDto Login(string username, string password)
        {
            LoginResultDto loginResultDto = new LoginResultDto();
            var user = userService.GetUserByUsername(username);
            if (user.Username.Equals(username))
            {
                if(user.Password.Equals(password))
                {
                    loginResultDto.LoginResult = Result.Success;
                    loginResultDto.User = user;
                    return loginResultDto;
                }
            }
            loginResultDto.LoginResult = Result.UserNotFound;
            return loginResultDto;
        }
    }
}