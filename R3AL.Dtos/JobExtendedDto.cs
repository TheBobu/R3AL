using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Dtos
{
    public class JobExtendedDto : JobDto
    {
        public List<GoalLightDto> Goals { get; set; }
        public List<ProjectLightDto> Projects { get; set; }
        public List<QuizLightDto> Quizzes { get; set; }
    }
}
