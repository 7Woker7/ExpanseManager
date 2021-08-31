using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Repositories
{
    public interface IHashing
    {
        string GetHash(string password);
    }
}
