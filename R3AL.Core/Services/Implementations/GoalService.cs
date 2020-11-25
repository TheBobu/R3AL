using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace R3AL.Core.Services.Implementations
{
    public class GoalService : BaseDbService, IGoalService
    {
        public GoalService(IContext context) : base(context)
        {
        }

        public Goal AddGoal(Goal goal)
        {
            goal = Context
                .Goals
                .Add(goal).Entity;

            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return goal;
        }

        public bool DeleteGoal(int id)
        {
            Context
                .Goals
                .Remove(GetGoalById(id));

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return true;
        }

        public Goal GetGoalById(int id)
        {
            var goal = Context
                .Goals
                .Where(x => x.GoalId.Equals(id))
                .FirstOrDefault();

            return goal;
        }

        public IEnumerable<Goal> GetGoals()
        {
            return Context
                .Goals
                .ToList();
        }

        public IEnumerable<Goal> GetGoalsByJobId(int id)
        {
            return Context
                .Goals
                .Where(x => x.JobId.Equals(id))
                .ToList();
        }

        public IEnumerable<Goal> GetGoalsByUserId(int userId)
        {
            return Context
                .Goals
                .Where(x => x.UserId.Equals(userId))
                .ToList();
        }

        public int GetNumberOfGoals(int jobId)
        {
            return Context
                .Goals
                .Where(x => x.JobId.Equals(jobId))
                .Count();
        }

        public Goal UpdateGoal(Goal goal)
        {
            Context
                .Goals
                .Update(goal);

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return goal;
        }
    }
}