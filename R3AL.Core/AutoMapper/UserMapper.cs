using AutoMapper;
using R3AL.Common.Enums;
using R3AL.Data.Entities;
using R3AL.Dtos;
using System;

namespace R3AL.Core.AutoMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDto>()
                .ForMember(d => d.UserType, o => o.MapFrom(s => Enum.GetName(typeof(UserType), s.UserType)))
                .ReverseMap()
                .ForMember(d => d.UserType, o => o.MapFrom(s => s.UserType));
            CreateMap<UserDto, UserExtendedDto>();
        }
    }
}