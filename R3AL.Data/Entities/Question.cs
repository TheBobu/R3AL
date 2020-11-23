using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace R3AL.Data.Entities
{
    [Table(nameof(Question))]
    public class Question
    {
        public int QuestionId { get; set; }
        public int QuizId { get; set; }
        public string Title { get; set; }
        public int Answer { get; set; }
    }
}
