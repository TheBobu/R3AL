using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Dtos
{
    public class GoalLightDto
    {
        public string Title { get; set; }
        public string GoalStatus { get; set; }
        public int GoalId { get; set; }
        public int Milestones { get; set; }
        public int CurrentProgress { get; set; }
    }
}
