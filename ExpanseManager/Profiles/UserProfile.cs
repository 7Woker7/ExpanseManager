using AutoMapper;
using ExpanseManager.DTO;
using ExpanseManager.Models;
using ExpanseManager.Extensions;

namespace ExpanseManager.Profiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<User, UserReadDto>();
      
            CreateMap<UserCreateDto, User>()
            .ForMember(p => p.BirthDate, o => o.MapFrom(r => r.BirthDate.CreateDate(r.Year,r.Month,r.Day)));
        }
    }
}
