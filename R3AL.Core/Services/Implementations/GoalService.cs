using R3AL.Core.Services.Interfaces;
using R3AL.Data;

namespace R3AL.Core.Services.Implementations
{
    public class GoalService : BaseDbService, IGoalService
    {
        public GoalService(IContext context) : base(context)
        {
        }
    }
}