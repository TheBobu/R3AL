using AutoMapper;
using R3AL.Data.Entities;
using R3AL.Dtos;

namespace R3AL.Core.AutoMapper
{
    public class UserMapper : Profile
    {
        public UserMapper()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();
        }
    }
}