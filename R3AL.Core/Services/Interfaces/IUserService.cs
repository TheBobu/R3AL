using R3AL.Data.Entities;

namespace R3AL.Core.Services.Interfaces
{
    public interface IUserService
    {
        User AddUser(User user);

        bool DeleteUser(int id);

        User GetUserById(int id);

        User GetUserByUsername(string username);

        User UpdateUser(User user);
    }
}