using R3AL.Core.Services.Interfaces;
using R3AL.Data;
using R3AL.Data.Entities;
using System.Collections.Generic;
using System.Linq;

namespace R3AL.Core.Services.Implementations
{
    public class JobService : BaseDbService, IJobService
    {
        public JobService(IContext context) : base(context)
        {
        }

        public Job AddJob(Job job)
        {
            job = Context
                .Jobs
                .Add(job).Entity;
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return job;
        }

        public bool DeleteJob(int id)
        {
            Context
                .Jobs
                .Remove(GetJobById(id));
            Context
                .SaveAsync()
                .ConfigureAwait(false);
            return true;
        }

        public Job GetJobById(int id)
        {
            return Context
                .Jobs
                .Where(x => x.JobId.Equals(id))
                .FirstOrDefault();
        }

        public IEnumerable<Job> GetJobs()
        {
            return Context
               .Jobs
               .ToList();
        }

        public IEnumerable<Job> GetJobsByUserId(int userId)
        {
            return Context
               .JobUsers
               .Where(x => x.UserId.Equals(userId))
               .Select(x => x.Job)
               .ToList();
        }

        public Job UpdateJob(Job job)
        {
            Context
                .Jobs
                .Update(job);
            Context
                .SaveAsync()
                .ConfigureAwait(false);

            return job;
        }
    }
}