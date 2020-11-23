using R3AL.Common.Enums;
using R3AL.Data.Entities;

namespace R3AL.Dtos
{
    public class LoginResultDto
    {
        public Result LoginResult { get; set; }
        public User User { get; set; }
    }
}