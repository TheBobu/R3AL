using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Core.AutoMapper
{
    public class QuizMapper: Profile
    {
        public QuizMapper()
        {
            CreateMap<Quiz, QuizDto>();
            CreateMap<Question, QuestionDto>();
            CreateMap<Response, ResponseDto>();
            CreateMap<Quiz, QuizLightDto>();
        }
    }
}
