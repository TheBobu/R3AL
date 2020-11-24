using AutoMapper;
using R3AL.Data.Entities;
using R3AL.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace R3AL.Core.AutoMapper
{
    public class JobMapper:Profile
    {
        public JobMapper()
        {
            CreateMap<Job, JobDto>();
            CreateMap<Job, JobExtendedDto>();
        }
    }
}
