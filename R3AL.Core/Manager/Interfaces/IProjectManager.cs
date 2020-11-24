using System;
using System.Collections.Generic;
using System.Text;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IProjectManager
    {
        List<ProjectDto> GetProjectsByUserId(int userId);
        ProjectDto GetProject(int projectId);

        List<ProjectDto> GetProjectsByGoaldId(int goalId);
    }
}
