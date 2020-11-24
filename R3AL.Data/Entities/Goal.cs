using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Goal))]
    public class Goal
    {
        public int? CurrentProgress { get; set; }
        public string Description { get; set; }
        public int GoalId { get; set; }

        [Required]
        public int GoalStatus { get; set; }

        [Required]
        public int JobId { get; set; }

        public Job Job { get; set; }

        public int? Milestones { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public int UserId { get; set; }

        public User User { get; set; }
    }
}