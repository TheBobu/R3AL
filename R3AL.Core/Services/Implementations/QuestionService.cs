using R3AL.Core.Services.Interfaces;
using R3AL.Data;

namespace R3AL.Core.Services.Implementations
{
    public class QuestionService : BaseDbService, IQuestionService
    {
        public QuestionService(IContext context) : base(context)
        {
        }
    }
}