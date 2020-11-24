using System;
using System.Collections.Generic;
using System.Text;
using R3AL.Data.Entities;

namespace R3AL.Core.Services.Interfaces
{
    public interface IQuizService
    {
        Quiz AddQuiz(Quiz quiz);
        bool DeleteQuiz(int quizId);
        Quiz GetQuizById(int quizId);
        IEnumerable<Quiz> GetQuizzesByGoalId(int goalId);
        Quiz UpdateQuiz(Quiz quiz);
    }
}
