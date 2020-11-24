using AutoMapper;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Core.AutoMapper
{
    public class ProjectMapper : Profile
    {
        public ProjectMapper()
        {
            CreateMap<Project, ProjectLightDto>();
        }
    }
}