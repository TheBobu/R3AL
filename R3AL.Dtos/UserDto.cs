using R3AL.Common.Enums;

namespace R3AL.Dtos
{
    public class UserDto
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }
        public string LastName { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string UserType { get; set; }
    }
}