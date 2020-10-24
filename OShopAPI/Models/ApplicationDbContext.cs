using Microsoft.EntityFrameworkCore;

namespace OShopAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Electronics"
                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Food"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Cloths"
                }
            );
        }



    }
}
