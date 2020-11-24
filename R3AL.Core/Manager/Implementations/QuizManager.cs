using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using R3AL.Core.Manager.Interfaces;
using R3AL.Core.Services.Interfaces;
using R3AL.Dtos;

namespace R3AL.Core.Manager.Implementations
{
    public class QuizManager : IQuizManager
    {
        private readonly IMapper mapper;
        private readonly IQuizService quizService;
        private readonly IQuestionService questionService;

        public QuizManager(IMapper mapper, IQuizService quizService, IQuestionService questionService)
        {
            this.mapper = mapper;
            this.quizService = quizService;
            this.questionService = questionService;
        }
        public IEnumerable<QuizDto> GetQuizzes(int goalId)
        {
            var quizzes = mapper.Map<IEnumerable<QuizDto>>(quizService.GetQuizzesByGoalId(goalId));
            foreach(var quiz in quizzes)
            {
                var questions = mapper.Map<List<QuestionDto>>(questionService.GetQuestionsByQuizId(quiz.QuizId));
                foreach (var question in questions)
                {
                    var responses = mapper.Map<List<ResponseDto>>(questionService.GetResponses(question.QuestionId));
                    question.Responses = responses;
                }
                quiz.Questions = questions;
            }
            return quizzes;
        }
    }
}
