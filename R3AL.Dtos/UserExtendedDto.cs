using System.Collections.Generic;

namespace R3AL.Dtos
{
    public class UserExtendedDto : UserDto
    {
        public List<GoalLightDto> Goals { get; set; }
        public List<ProjectLightDto> Projects { get; set; }
    }
}