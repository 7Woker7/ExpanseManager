using ExpanseManager.Data;
using ExpanseManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace ExpanseManager.Repositories
{
    public class TransactionRepository : ITransactionRepository
    {
        private readonly ExpanseManagerContext _context;

        public TransactionRepository(ExpanseManagerContext context)
        {
            _context = context;
        }
        public Transaction Create(Transaction transaction)
        {
            var createTransaction = _context.Transactions.Add(transaction);
            _context.SaveChanges();
            return createTransaction.Entity;
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IList<Transaction> GetAll()
        {
            return _context.Transactions.ToList();
        }

        public Transaction GetById(int id)
        {
            return _context.Transactions.FirstOrDefault(p => p.Id == id);
        }

        public int SaveChanges()
        {
            return (_context.SaveChanges());
        }

        public Transaction Update(Transaction transaction)
        {
            throw new System.NotImplementedException();
        }
    }
}
