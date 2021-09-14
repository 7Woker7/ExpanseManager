using AutoMapper;
using ExpanseManager.DTO;
using ExpanseManager.Models;

namespace ExpanseManager.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();
            CreateMap<UserCreateDto, User>();
        }
    }
}
