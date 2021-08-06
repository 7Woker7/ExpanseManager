using AutoMapper;
using ExpanseManager.DTO_s;
using ExpanseManager.Models;
using ExpanseManager.Repositories;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpanseManager.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserController(IUserRepository repository, IMapper mapper)
        {
            _repository= repository;
            _mapper = mapper;
        }

        [HttpGet]
        public ActionResult <IEnumerable<UserReadDto>> GetAll()
        {
            var userItems = _repository.GetAll();
            return Ok(_mapper.Map<IEnumerable<UserReadDto>>(userItems));
        }

        [HttpGet("{id}")]
        public ActionResult <UserReadDto> GetById(int id)
        {
            var userItem = _repository.GetById(id);
            if (userItem != null) 
            { 
                return Ok(_mapper.Map<UserReadDto>(userItem));
            }
            return NotFound();
        }

        [HttpPost]
        public ActionResult<UserReadDto> Create([FromBody] UserCreateDto userCreateDto)
        {
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.Create(userModel);

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return Ok(userReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] UserCreateDto _userCreateDto)
        {
            var _userModel = _repository.GetById(id);
            if(_userModel == null)
            {
                return NotFound();
            }

            _mapper.Map(_userCreateDto, _userModel);

            _repository.SaveChanges();

            return NoContent();
        }
    }
}
