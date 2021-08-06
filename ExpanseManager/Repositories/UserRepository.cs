using ExpanseManager.Data;
using ExpanseManager.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ExpanseManager.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ExpanseManagerContext _context;

        public UserRepository(ExpanseManagerContext context)
        {
            _context = context;
        }

        public IEnumerable<User> GetAll()
        {
            return _context.Users.ToList();
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public User Create(User user)
        {
            var createUser = _context.Users.Add(user);
            _context.SaveChanges();
            return createUser.Entity;

        }

        public int SaveChanges()
        {
           return(_context.SaveChanges());
        }

        public void Update(User user)
        {
            
        }
    }
}
