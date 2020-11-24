using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IGoalManager
    {
        IEnumerable<GoalDto> GetGoals(int userId);
    }
}