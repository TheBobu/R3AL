using AutoMapper;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Core.AutoMapper
{
    public class GoalMapper : Profile
    {
        public GoalMapper()
        {
            CreateMap<Goal, GoalLightDto>();
        }
    }
}