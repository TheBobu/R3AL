using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IGoalManager
    {
        List<GoalDto> GetGoals(int userId);
        GoalExtendedDto GetExtendedGoal(int goalId);
    }
}