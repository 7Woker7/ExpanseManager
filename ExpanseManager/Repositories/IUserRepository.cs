using ExpanseManager.Models;
using System.Collections.Generic;

namespace ExpanseManager.Repositories
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(int id);
        User Create(User user);
        void Update(User user);
        int SaveChanges();
    }
}
