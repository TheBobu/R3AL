using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(ProjectGoal))]
    public class ProjectGoal
    {
        public int ProjectGoalId { get; set; }

        [Required]
        public int ProjectId { get; set; }

        public Project Project { get; set; }

        [Required]
        public int GoalId { get; set; }

        public Goal Goal { get; set; }
    }
}