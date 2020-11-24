using System.Collections.Generic;
using System.Linq;
using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;

namespace R3AL.Core.Services.Implementations
{
    public class QuizService : BaseDbService, IQuizService
    {
        public QuizService(IContext context) : base(context)
        {
        }

        public Quiz AddQuiz(Quiz quiz)
        {
            quiz = Context
                .Quizzes
                .Add(quiz)
                .Entity;
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return quiz;
        }

        public bool DeleteQuiz(int quizId)
        {
            Context
                .Quizzes
                .Remove(GetQuizById(quizId));
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return true;
        }

        public Quiz GetQuizById(int quizId)
        {
            return Context
                .Quizzes
                .Where(x => x.QuizId.Equals(quizId))
                .FirstOrDefault();
        }

        public IEnumerable<Quiz> GetQuizzesByGoalId(int goalId)
        {
            return Context
                .Quizzes
                .Where(x => x.GoalId.Equals(goalId))
                .ToList();
        }

        public Quiz UpdateQuiz(Quiz quiz)
        {
            Context
                .Quizzes
                .Update(quiz);
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return quiz;
        }
    }
}