﻿using R3AL.Data.Entities;
using System.Collections.Generic;

namespace R3AL.Core.Services.Interfaces
{
    public interface IGoalService
    {
        Goal AddGoal(Goal goal);

        bool DeleteGoal(int id);

        Goal GetGoalById(int id);

        IEnumerable<Goal> GetGoalsByJobId(int id);

        IEnumerable<Goal> GetGoals();

        IEnumerable<Goal> GetGoalsByUserId(int userId);

        int GetNumberOfGoals(int jobId);

        Goal UpdateGoal(Goal goal);
    }
}