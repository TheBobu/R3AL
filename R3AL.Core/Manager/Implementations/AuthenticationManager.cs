using AutoMapper;
using R3AL.Common.Enums;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Data.Entities;
using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Implementations
{
    public class AuthenticationManager : IAuthenticationManager
    {
        private readonly IUserService userService;
        private readonly IGoalService goalService;
        private readonly IProjectService projectService;
        private readonly IMapper mapper;

        public AuthenticationManager(
            IUserService userService, 
            IGoalService goalService, 
            IProjectService projectService, 
            IMapper mapper)
        {
            this.userService = userService;
            this.goalService = goalService;
            this.projectService = projectService;
            this.mapper = mapper;
        }

        public UserDto GetUser(int id)
        {
            return mapper.Map<UserDto>(userService.GetUserById(id));
        }

        public UserExtendedDto GetUserExtended(int id)
        {
            var user = mapper.Map<UserExtendedDto>(GetUser(id));

            var goals = mapper.Map<List<GoalLightDto>>(goalService.GetGoalsByUserId(id));
            user.Goals = goals;

            var projects = mapper.Map<List<ProjectLightDto>>(projectService.GetProjectsByUserId(id));
            user.Projects = projects;

            return user;
        }

        public LoginResultDto Login(string username, string password)
        {
            LoginResultDto loginResultDto = new LoginResultDto();
            var user = userService.GetUserByUsername(username);
            if (user.Username.Equals(username))
            {
                if(user.Password.Equals(password))
                {
                    loginResultDto.LoginResult = Result.Success;
                    loginResultDto.User = user;
                    return loginResultDto;
                }
            }
            loginResultDto.LoginResult = Result.UserNotFound;
            return loginResultDto;
        }

        public UserDto Register(User user)
        {
            return mapper.Map<UserDto>(userService.AddUser(user));
        }
    }
}