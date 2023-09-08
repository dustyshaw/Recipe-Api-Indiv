using Microsoft.EntityFrameworkCore;

namespace RECIAPI.Data
{
    public class RecipeContext : DbContext
    {
        // We pass in the DbContextOptions as an dependency injection
        public RecipeContext(DbContextOptions<RecipeContext> options) : base(options)
        {
            
        }

        // We define which tables we want in our database by instantiating DbSets
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Ingredient> Ingredients { get; set;}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
