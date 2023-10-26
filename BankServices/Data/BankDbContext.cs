using BankServices.models;
using Microsoft.EntityFrameworkCore;

namespace BankServices.Data
{
    public class BankDbContext : DbContext
    {
        public BankDbContext(DbContextOptions<BankDbContext> options) : base(options) { }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Bank> Banks { get; set; }
        public DbSet<Customer> Customers { get; set; }
    }

}
