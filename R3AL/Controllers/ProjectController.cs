using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R3AL.Core.Manager.Interfaces;
using R3AL.Dtos;

namespace R3AL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectManager projectManager;

        public ProjectController(IProjectManager projectManager)
        {
            this.projectManager = projectManager;
        }

        [HttpGet("project/{id}")]
        public ActionResult<ProjectDto> GetProject([FromRoute] int id)
        {
            return projectManager.GetProject(id);
        }

        [HttpGet("goal/{id}")]
        public ActionResult<List<ProjectDto>> GetProjectsByGoalId([FromRoute] int id)
        {
            return projectManager.GetProjectsByGoaldId(id);
        }

        [HttpGet("{id}")]
        public ActionResult<List<ProjectDto>> GetProjectsByUserId([FromRoute] int id)
        {
            return projectManager.GetProjectsByUserId(id);
        }


    }
}
