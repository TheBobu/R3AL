using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace R3AL.Core.Services.Implementations
{
    public class ProjectService : BaseDbService, IProjectService
    {
        public ProjectService(IContext context) : base(context)
        {
        }

        public Project AddProject(Project project)
        {
            project = Context
                .Projects
                .Add(project).Entity;

            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return project;
        }

        public bool DeleteProject(int id)
        {
            Context
                .Projects
                .Remove(GetProjectById(id));

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return true;
        }

        public int GetNumberOfProjects(int goalId)
        {
            return Context
                .ProjectGoals
                .Where(x => x.GoalId.Equals(goalId))
                .Count();
        }

        public Project GetProjectById(int id)
        {
            var project = Context
                .Projects
                .Where(x => x.ProjectId.Equals(id))
                .FirstOrDefault();

            return project;
        }

        public IEnumerable<Project> GetProjectsByJobId(int id)
        {
            return Context
                .ProjectGoals
                .Where(x => x.Goal.JobId.Equals(id))
                .Select(x => x.Project)
                .ToList();
        }

        public IEnumerable<Project> GetProjects()
        {
            return Context
                .Projects
                .ToList();
        }

        public IEnumerable<Project> GetProjectsByGoalId(int goalId)
        {
            return Context
                .ProjectGoals
                .Where(x => x.Goal.GoalId.Equals(goalId))
                .Select(x => x.Project)
                .ToList();
        }

        public IEnumerable<Project> GetProjectsByUserId(int userId)
        {
            return Context
                .ProjectGoals
                .Where(x => x.Goal.UserId.Equals(userId))
                .Select(x => x.Project)
                .Distinct()
                .ToList();
        }

        public Project UpdateProject(Project project)
        {
            Context
                .Projects
                .Update(project);

            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return project;
        }
    }
}