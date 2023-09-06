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

            modelBuilder.Entity<Recipes_domains>().HasKey(i => new {i.RecipeId, i.DomainId});
            // TODO: custom code here


            modelBuilder.Entity<Recipes_domains>()
                .HasOne(x => x.BoardGame)
                .WithMany(y => y.Recipes_domains)
                .HasForeignKey(f => f.BoardGameId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Recipes_domains>()
                .HasOne(o => o.Domain)
                .WithMany(m => m.Recipes_domains)
                .HasForeignKey(f => f.DomainId)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

