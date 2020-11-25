using R3AL.Data.Entities;
using System.Collections.Generic;

namespace R3AL.Core.Services.Interfaces
{
    public interface IJobService
    {
        Job AddJob(Job job);

        bool DeleteJob(int id);

        Job GetJobById(int id);

        IEnumerable<Job> GetJobs();

        IEnumerable<Job> GetJobsByUserId(int userId);

        bool IsEnrolled(int userId, int jobId);

        Job UpdateJob(Job job);
    }
}