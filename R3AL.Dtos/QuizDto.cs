using System.Collections.Generic;

namespace R3AL.Dtos
{
    public class QuizDto
    {
        public List<QuestionDto> Questions { get; set; }
        public int QuizId { get; set; }
        public int Score { get; set; }
    }
}