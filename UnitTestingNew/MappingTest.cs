using AutoMapper;
using ExpanseManager.DTO;
using ExpanseManager.Extensions;
using ExpanseManager.Models;
using ExpanseManager.Profiles;
using System;
using Xunit;

namespace UnitTestingNew
{
    public class MappingTest
    {
        //private readonly IMapper _mapper;

        //public MappingTest(IMapper mapper)
        //{
        //    _mapper = mapper;
        //}
        public UserCreateDto GetDtoEntity()
        {
            return new UserCreateDto()
            {
                Name = "Igor",
                Password = "qwerty12345",
                Year = 1999,
                Month = 10,
                Day = 10,
            };
        }
        public User GetEntity()
        {
            return new User()
            {
                Name = "Igor",
                Password = "qwerty12345",
                BirthDate = new DateTime(1999, 10, 10)
            };
        }

        [Fact]
        public void ShouldMappProfile()
        {
            //arrange
            var config = new MapperConfiguration(cfg => cfg.AddProfile<UserProfile>());
            var mapper = config.CreateMapper();
            var entity = GetEntity();
            var altentity = GetDtoEntity();
            //act
            var userModel = mapper.Map<UserCreateDto, User>(altentity);
            //assert
            Assert.Equal(entity, userModel);
        }
        [Fact]
        public void ShouldMappUser()
        {
            var entity = GetEntity();
            var altentity = GetDtoEntity();



            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserCreateDto, User>());
            config.AssertConfigurationIsValid();
        }
        [Fact]
        public void ShouldMappSpecific()
        {
            var entity = GetEntity();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<UserCreateDto, User>().ForMember(p => p.BirthDate, o => o.MapFrom(r => r.BirthDate.CreateDate(r.Year, r.Month, r.Day))));
            config.AssertConfigurationIsValid();
        }
        [Fact]
        public void ShouldCreateDate()
        {
            DateTime expected = DateTime.Today;
            DateTime bait = DateTime.Today;
            DateTime actual = DateExtension.CreateDate(bait, 2021, 12, 3);
            Assert.Equal(expected, actual);
        }
    }
}
