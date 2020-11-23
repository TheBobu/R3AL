using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Quiz))]
    public class Quiz
    {
        public int QuizId { get; set; }

        [Required]
        public int GoalId { get; set; }
    }
}