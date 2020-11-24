using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Implementations
{
    public class ProjectManager : IProjectManager
    {
        private readonly IMapper mapper;
        private readonly IProjectService projectService;
        private readonly IGoalService goalService;
        private readonly IQuizService quizService;
        private readonly IQuestionService questionService;
        private readonly IUserService userService;

        public ProjectManager(IMapper mapper, IProjectService projectService, IGoalService goalService)
        {
            this.mapper = mapper;
            this.projectService = projectService;
            this.goalService = goalService;
        }

        public ProjectDto GetProject(int projectId)
        {
            return mapper.Map<ProjectDto>(projectService.GetProjectById(projectId));
        }

        public List<ProjectDto> GetProjectsByUserId(int userId)
        {
            return mapper.Map<List<ProjectDto>>(projectService.GetProjectsByUserId(userId));
        }

        public List<ProjectDto> GetProjectsByGoaldId(int goalId)
        {
            return mapper.Map<List<ProjectDto>>(projectService.GetProjectsByGoalId(goalId));
        }


    }
}
