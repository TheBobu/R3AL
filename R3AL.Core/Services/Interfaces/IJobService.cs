using R3AL.Data.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Core.Services.Interfaces
{
    public interface IJobService
    {
        Job AddJob(Job job);
        bool DeleteJob(int id);
        Job GetJobById(int id);
        IEnumerable<Job> GetJobs();
        IEnumerable<Job> GetJobsByUserId(int userId);
        Job UpdateJob(Job job);
    }
}
