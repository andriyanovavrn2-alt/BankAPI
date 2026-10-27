using BankAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace BankAPI
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
        {

        }

        public DbSet<User> User { get; set; }
        public DbSet<Account> Account{ get; set; }
        public DbSet<Transaction> Transaction { get; set; }
        public DbSet<TypeOperation> TypeOperation { get; set; }

    }
}
