using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Dtos
{
    public class GoalDto
    {
        public int? CurrentProgress { get; set; }
        public string Description { get; set; }
        public int GoalId { get; set; }

        public int GoalStatus { get; set; }

        public int? Milestones { get; set; }

        public string Title { get; set; }
    }
}
