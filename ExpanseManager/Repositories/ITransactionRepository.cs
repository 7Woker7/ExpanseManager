using ExpanseManager.Models;
using System.Collections.Generic;

namespace ExpanseManager.Repositories
{
    public interface ITransactionRepository
    {
        Transaction Create(Transaction transaction);

        IList<Transaction> GetAll();

        Transaction GetById(int id);

        Transaction Update(Transaction transaction);

        void Delete(int id);

        int SaveChanges();
    }
}
