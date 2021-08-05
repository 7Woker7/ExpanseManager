using ExpanseManager.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpanseManager.Data
{
    public class ExpanseManagerContext : DbContext
    {
        public ExpanseManagerContext(DbContextOptions<ExpanseManagerContext> opt) : base(opt)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(local);Database=ExpanceManager;Trusted_Connection=True;");
        }
    }

}
