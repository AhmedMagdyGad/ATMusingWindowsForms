using Microsoft.EntityFrameworkCore;

namespace ATM_Project.Models;
internal class ApplicationDbContext:DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            "Server=DESKTOP-0GT95GR\\SQLEXPRESS;Database=ATM;Integrated Security=True;Trust Server Certificate = true;"
        );
    }
}
