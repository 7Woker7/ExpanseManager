using ExpanseManager.Models;
using Microsoft.EntityFrameworkCore;

namespace ExpanseManager.Data
{
    public class ExpanseManagerContext : DbContext
    {
        public ExpanseManagerContext(DbContextOptions<ExpanseManagerContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
    
    }

}
