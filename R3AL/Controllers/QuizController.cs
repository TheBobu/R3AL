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
    public class QuizController : ControllerBase
    {
        private readonly IQuizManager quizManager;

        public QuizController(IQuizManager quizManager)
        {
            this.quizManager = quizManager;
        }

        [HttpGet("goal/{id}")]
        public ActionResult<List<QuizDto>> GetQuizzes([FromRoute] int id)
        {
            return quizManager.GetQuizzes(id);
        }

        [HttpGet("{id}")]
        public ActionResult<QuizDto> GetQuiz([FromRoute] int id)
        {
            return quizManager.GetQuiz(id);
        }
    }
}
