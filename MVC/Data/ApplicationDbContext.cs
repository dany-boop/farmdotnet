using Microsoft.EntityFrameworkCore;
using MVC.Models.Entity;

namespace MVC.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


            public DbSet<User> User { get; set; }

            public DbSet<Farm> Farm { get; set; }

            public DbSet<FarmExpense> FarmExpense { get; set; }

            public DbSet<FarmExpenseCategory> FarmExpenseCategory { get; set; }

            public DbSet<FarmImg> FarmImg { get; set; }

            public DbSet<CattleType> CattleType { get; set; }
    }
}
