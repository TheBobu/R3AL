using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Core.Manager.Interfaces
{
    public interface IJobManager
    {
        JobDto GetJob(int id);

        JobExtendedDto GetJobExtended(int id);

        List<JobDto> GetJobs(int userId);
    }
}