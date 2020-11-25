using Microsoft.AspNetCore.Mvc;
using R3AL.Core.Manager.Interfaces;
using R3AL.Dtos;
using System.Collections.Generic;

namespace R3AL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JobsController : ControllerBase
    {
        private readonly IJobManager jobManager;

        public JobsController(IJobManager jobManager)
        {
            this.jobManager = jobManager;
        }

        [HttpGet("{id}/List")]
        public ActionResult<List<JobDto>> GetJobs([FromRoute] int id)
        {
            return jobManager.GetJobs(id);
        }

        [HttpGet("{id}/extended")]
        public ActionResult<JobExtendedDto> GetJob([FromRoute] int id)
        {
            return jobManager.GetJobExtended(id);
        }
    }
}