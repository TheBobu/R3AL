using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace R3AL.Data.Entities
{
    [Table(nameof(Question))]
    public class Question
    {
        public int QuestionId { get; set; }

        [Required]
        public int QuizId { get; set; }

        public Quiz Quiz { get; set; }

        [Required]
        [MaxLength(300)]
        public string Title { get; set; }
    }
}