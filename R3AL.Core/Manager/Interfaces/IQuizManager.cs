using System;
using System.Collections.Generic;
using System.Text;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IQuizManager
    {
        List<QuizDto> GetQuizzes(int goalId);
        QuizDto GetQuiz(int quizId);
    }
}
