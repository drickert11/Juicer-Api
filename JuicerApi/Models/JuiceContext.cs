using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace JuicerApi.Models
{
    public class JuiceContext : DbContext
    {
        public JuiceContext(DbContextOptions<JuiceContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Juice>().ToTable("dbo.tblJuice");
            modelBuilder.Entity<Ingredient>().ToTable("dbo.tblIngredient");
            modelBuilder.Entity<MealPlan>().ToTable("dbo.tblMealPlan");
            modelBuilder.Entity<User>().ToTable("dbo.tblUser");
        }

        public DbSet<Juice> Juices { get; set; } = null!;
        public DbSet<Ingredient> Ingredients { get; set; } = null!;
        public DbSet<MealPlan> MealPlans { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
    }
}
