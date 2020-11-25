using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;
using System.Linq;

namespace R3AL.Core.Services.Implementations
{
    public class UserService : BaseDbService, IUserService
    {
        public UserService(IContext context) : base(context)
        {
        }

        public User AddUser(User user)
        {
            var newUser = user;
            Context
                .Users
                .Add(newUser);

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return newUser;
        }

        public bool DeleteUser(int id)
        {
            var user = GetUserById(id);
            Context
                .Users
                .Remove(user);

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return true;
        }

        public User GetUserById(int id)
        {
            var user = Context
                .Users
                .Where(x => x.UserId.Equals(id))
                .FirstOrDefault();

            return user;
        }

        public User GetUserByUsername(string username)
        {
            var user = Context
                .Users
                .Where(x => x.Username.Equals(username))
                .FirstOrDefault();

            return user;
        }

        public User UpdateUser(User user)
        {
            Context
                .Users
                .Update(user);

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return user;
        }
    }
}