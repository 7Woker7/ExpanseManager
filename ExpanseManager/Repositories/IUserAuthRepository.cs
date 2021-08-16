using ExpanseManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Repositories
{
    public interface IUserAuthRepository
    {
        User GetById(int id);

        User GetByNameAndPassword(string name, string password);
    }
}
