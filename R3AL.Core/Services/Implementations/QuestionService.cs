using System.Collections.Generic;
using System.Linq;
using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;

namespace R3AL.Core.Services.Implementations
{
    public class QuestionService : BaseDbService, IQuestionService
    {
        public QuestionService(IContext context) : base(context)
        {
        }

        public Question AddQuestion(Question question)
        {
            question = Context
                .Questions
                .Add(question).Entity;

            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return question;
        }

        public bool DeleteQuestion(int questionId)
        {
            Context.Questions.Remove(GetQuestionById(questionId));
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return true;
        }

        public Question GetQuestionById(int questionId)
        {
            return Context
                .Questions
                .Where(x => x.QuestionId.Equals(questionId))
                .FirstOrDefault();
        }

        public IEnumerable<Question> GetQuestionsByQuizId(int quizId)
        {
            return Context
                .Questions
                .Where(x => x.QuizId.Equals(quizId))
                .ToList();
        }

        public IEnumerable<Response> GetResponses(int questionId)
        {
            return Context
                .Responses
                .Where(x => x.QuestionId.Equals(questionId))
                .ToList();
        }

        public Question UpdateQuestion(Question question)
        {
            Context
                .Questions
                .Update(question);
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return question;
        }
    }
}