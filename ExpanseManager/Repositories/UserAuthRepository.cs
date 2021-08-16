using ExpanseManager.Data;
using ExpanseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Repositories
{
    public class UserAuthRepository : IUserAuthRepository
    {
        private readonly ExpanseManagerContext _context;

        public UserAuthRepository(ExpanseManagerContext context)
        {
            _context = context;
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(p => p.Id == id);
        }

        public User GetByNameAndPassword(string name, string password)
        {
            return _context.Users.FirstOrDefault(p => p.Name == name && p.Password == password);
        }
    }
}
