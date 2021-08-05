using ExpanseManager.Models;
using ExpanseManager.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Controllers
{
    [Route("api/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _repository;
        public UserController(IUserRepository repository)
        {
            _repository= repository;
        }

        //private readonly UserRepository _userRepository = new UserRepository();
        

        [HttpGet]
        public ActionResult <IEnumerable<User>> GetAll()
        {
            var userItems = _repository.GetAll();
            return Ok(userItems);
        }

        [HttpGet("{id}")]
        public ActionResult <IEnumerable<User>> GetById(int id)
        {
            var userItems = _repository.GetById(id);
            return Ok(userItems);
        }
    }
}
