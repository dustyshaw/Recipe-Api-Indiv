using Microsoft.EntityFrameworkCore;
using RECIAPI.Models;



public class ApplicationDbContext : DbContext
{

    public ApplicationDbContext(
        DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Recipes_domains>().HasKey(i => new { i.RecipeId, i.DomainId });
        // TODO: custom code here


        modelBuilder.Entity<Recipes_domains>()
            .HasOne(x => x.BoardGame)
            .WithMany(y => y.Recipes_domains)
            .HasForeignKey(f => f.RecipeId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<Recipes_domains>()
            .HasOne(o => o.Domain)
            .WithMany(m => m.Recipes_Domains)
            .HasForeignKey(f => f.DomainId)
            .IsRequired()
            .OnDelete(DeleteBehavior.Cascade);


    }

    public DbSet<Recipe> Recipes => Set<Recipe>();
    public DbSet<Domain> Domains => Set<Domain>();
    public DbSet<Recipes_domains> Recipes_Domains
           => Set<Recipes_domains>();

}

