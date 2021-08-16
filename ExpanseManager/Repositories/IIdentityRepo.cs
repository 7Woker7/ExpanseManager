using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Repositories
{
    public interface IIdentityRepo
    {
        string Authenticate(string name, string password);
    }
}
