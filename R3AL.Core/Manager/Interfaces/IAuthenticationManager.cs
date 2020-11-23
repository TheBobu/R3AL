using R3AL.Data.Entities;
using R3AL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IAuthenticationManager
    {
        LoginResultDto Login(string username, string password);

        UserDto GetUser(int id);

        UserExtendedDto GetUserExtended(int id);

        UserDto Register(User user);
    }
}
