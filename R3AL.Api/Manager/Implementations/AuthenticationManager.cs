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
            throw new System.NotImplementedException();
        }
    }
}