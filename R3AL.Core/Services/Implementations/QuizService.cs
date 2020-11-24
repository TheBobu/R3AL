using R3AL.Core.Services.Interfaces;
using R3AL.Data;

namespace R3AL.Core.Services.Implementations
{
    public class QuizService : BaseDbService, IQuizService
    {
        public QuizService(IContext context) : base(context)
        {
        }
    }
}