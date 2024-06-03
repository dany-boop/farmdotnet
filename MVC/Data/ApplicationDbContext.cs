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


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for User
            var userId = Guid.NewGuid();
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = userId,
                    Name = "John Doe",
                    Email = "john.doe@example.com",
                    Password = "password123",
                    Phone = "1234567890",
                    Role = "investor",
                    Is_active = true
                }
            );

            // Seed data for CattleType
            var cattleTypeId = Guid.NewGuid();
            modelBuilder.Entity<CattleType>().HasData(
                new CattleType
                {
                    Id = cattleTypeId,
                    Name = "Type1",
                    Note = "Note for Type1",
                    Is_active = true
                }
            );

            // Seed data for Farm
            var farmId = Guid.NewGuid();
            modelBuilder.Entity<Farm>().HasData(
                new Farm
                {
                    Id = farmId,
                    Code = "FARM001",
                    Type_Id = cattleTypeId, // Set the correct CattleType Id
                    Investor_Id = userId,   // Set the correct User Id
                    Buy_Price = 1000,
                    Sell_Price = 1500,
                    Treament_Price = 200,
                    Status = 1,
                    Male_Breeder = Guid.NewGuid(),
                    Female_Breeder = Guid.NewGuid()
                }
            );

            modelBuilder.Entity<FarmExpense>().HasData(
                new FarmExpense
                {
                    Id = Guid.NewGuid(),
                    Farm_Id = farmId,
                    Date = DateTime.Now,
                    Total = 
                }
                );
        }
    }
}
