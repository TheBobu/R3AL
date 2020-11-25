using AutoMapper;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Implementations
{
    public class JobManager : IJobManager
    {
        private readonly IMapper mapper;
        private readonly IJobService jobService;
        private readonly IGoalService goalService;
        private readonly IProjectService projectService;
        private readonly IQuizService quizService;

        public JobManager(
            IMapper mapper,
            IJobService jobService,
            IGoalService goalService,
            IProjectService projectService,
            IQuizService quizService)
        {
            this.mapper = mapper;
            this.jobService = jobService;
            this.goalService = goalService;
            this.projectService = projectService;
            this.quizService = quizService;
        }

        public JobDto GetJob(int id)
        {
            var job = mapper.Map<JobDto>(jobService.GetJobById(id));
            job.NumberOfGoals = goalService.GetNumberOfGoals(id);
            job.NumberOfProjects = 0;
            job.NumberOfQuizzes = 0;

            foreach (var goal in goalService.GetGoalsByJobId(id))
            {
                job.NumberOfProjects += projectService.GetNumberOfProjects(goal.GoalId);
                job.NumberOfQuizzes += quizService.GetNumberOfQuizzes(goal.GoalId);
            }

            return job;
        }

        public JobExtendedDto GetJobExtended(int id)
        {
            var job = mapper.Map<JobExtendedDto>(GetJob(id));
            job.Goals = mapper.Map<List<GoalLightDto>>(goalService.GetGoalsByJobId(id));
            job.Projects = mapper.Map<List<ProjectLightDto>>(projectService.GetProjectsByJobId(id));
            job.Quizzes = mapper.Map<List<QuizLightDto>>(quizService.GetQuizzesByJobId(id));

            return job;
        }

        public List<JobDto> GetJobs(int userId)
        {
            var jobs = new List<JobDto>();

            foreach (var job in jobService.GetJobs())
            {
                var aux = GetJob(job.JobId);
                if (jobService.IsEnrolled(userId, job.JobId))
                {
                    aux.Status = "Enrolled";
                }
                else
                {
                    aux.Status = "Available";
                }
                jobs.Add(aux);
            }

            return jobs;
        }
    }
}