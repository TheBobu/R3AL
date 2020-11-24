using AutoMapper;
using R3AL.Common.Enums;
using R3AL.Data.Entities;
using R3AL.Dtos;
using System;

namespace R3AL.Core.AutoMapper
{
    public class GoalMapper : Profile
    {
        public GoalMapper()
        {
            CreateMap<Goal, GoalLightDto>()
                .ForMember(d => d.GoalStatus, o => o.MapFrom(s => Enum.GetName(typeof(GoalStatus), s.GoalStatus)));
        }
    }
}