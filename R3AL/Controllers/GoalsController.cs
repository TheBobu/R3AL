using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using R3AL.Core.Manager.Interfaces;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalsController : ControllerBase
    {
        private readonly IGoalManager goalManager;

        public GoalsController(IGoalManager goalManager
            )
        {
            this.goalManager = goalManager;
        }

        [HttpGet("users/{id}")]
        public ActionResult <List<GoalDto>> GetGoalsByUserId([FromRoute] int id)
        {
            return goalManager.GetGoals(id);
        }

        [HttpGet("{id}/extended")]
        public ActionResult<GoalExtendedDto> GetExtendedGoal([FromRoute] int id)
        {
            return goalManager.GetExtendedGoal(id);
        }
    }
}
