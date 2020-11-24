using R3AL.Data.Entities;
using System.Collections.Generic;

namespace R3AL.Core.Services.Interfaces
{
    public interface IProjectService
    {
        Project AddProject(Project project);

        bool DeleteProject(int id);

        Project GetProjectById(int id);

        IEnumerable<Project> GetProjects();

        IEnumerable<Project> GetProjectsByGoalId(int goalId);

        IEnumerable<Project> GetProjectsByJobId(int id);

        IEnumerable<Project> GetProjectsByUserId(int userId);

        int GetNumberOfProjects(int goalId);

        Project UpdateProject(Project project);
    }
}