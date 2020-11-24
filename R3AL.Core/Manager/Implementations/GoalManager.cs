using AutoMapper;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Implementations
{
    public class GoalManager : IGoalManager
    {
        private readonly IGoalService goalService;
        private readonly IMapper mapper;
        private readonly IProjectService projectService;
        private readonly IQuizService quizService;

        public GoalManager(
            IGoalService goalService,
            IMapper mapper, 
            IProjectService projectService, 
            IQuizService quizService)
        {
            this.goalService = goalService;
            this.mapper = mapper;
            this.projectService = projectService;
            this.quizService = quizService;
        }
        public IEnumerable<GoalDto> GetGoals(int userId)
        {
            return mapper.Map<List<GoalDto>>(goalService.GetGoalsByUserId(userId));
        }

        public GoalExtendedDto GetExtendedGoal(int goalId)
        {
            GoalExtendedDto goal = mapper.Map<GoalExtendedDto>(goalService.GetGoalById(goalId));
            var projects = mapper.Map<List<ProjectDto>>(projectService.GetProjectsByGoalId(goalId));
            goal.Projects = projects;
            var quizzes = mapper.Map<List<QuizDto>>(quizService.GetQuizzesByGoalId(goalId));
            goal.Quizzes = quizzes;

            return goal;
        }
    }
}