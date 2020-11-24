using System.Collections.Generic;

namespace R3AL.Dtos
{
    public class GoalExtendedDto : GoalDto
    {
        public List<ProjectDto> Projects { get; set; }
        public List<int> Quizzes { get; set; }
    }
}