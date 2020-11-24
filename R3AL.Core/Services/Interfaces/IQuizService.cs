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
        int GetNumberOfQuizzes(int goalId);
        Quiz GetQuizById(int quizId);
        IEnumerable<Quiz> GetQuizzesByGoalId(int goalId);
        IEnumerable<Quiz> GetQuizzesByJobId(int jobId);
        Quiz UpdateQuiz(Quiz quiz);
    }
}
