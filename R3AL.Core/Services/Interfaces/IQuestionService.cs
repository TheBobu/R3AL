using System;
using System.Collections.Generic;
using System.Text;
using R3AL.Data.Entities;

namespace R3AL.Core.Services.Interfaces
{
    public interface IQuestionService
    {
        Question AddQuestion(Question question);
        bool DeleteQuestion(int questionId);
        Question GetQuestionById(int questionId);
        IEnumerable<Question> GetQuestionsByQuizId(int quizId);
        Question UpdateQuestion(Question question);
    }
}
