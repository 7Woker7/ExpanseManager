using AutoMapper;
using ExpanseManager.DTO;
using ExpanseManager.Models;
using ExpanseManager.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ExpanseManager.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        private readonly IHashing _hashing;

        public UserController(IUserRepository repository, IMapper mapper, IHashing hashing)
        {
            _repository= repository;
            _mapper = mapper;
            _hashing = hashing;
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
            userCreateDto.Password = _hashing.GetHash(userCreateDto.Password);
            var userModel = _mapper.Map<User>(userCreateDto);
            _repository.Create(userModel);

            var userReadDto = _mapper.Map<UserReadDto>(userModel);

            return Ok(userReadDto);
        }

        [HttpPut("{id}")]
        public ActionResult Update(int id, [FromBody] UserCreateDto userUpdateDto)
        {
            var userUpdateModel = _repository.GetById(id);
            if(userUpdateModel == null)
            {
                return NotFound();
            }

            _mapper.Map(userUpdateDto, userUpdateModel);

            _repository.SaveChanges();

            return NoContent();
        }

        [Authorize]
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var userDeleteModel = _repository.GetById(id);
            if (userDeleteModel == null)
            {
                return NotFound();
            }
            _repository.Delete(userDeleteModel);
            
            return NoContent();
        }
    }
}
