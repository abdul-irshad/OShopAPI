using Microsoft.EntityFrameworkCore;

namespace OShopAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

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
                    CategoryName = "Mobile"
                },
                new Category
                {
                    CategoryId = 3,
                    CategoryName = "Appliances"
                },
                 new Category
                 {
                     CategoryId = 4,
                     CategoryName = "Fashion"
                 },
                  new Category
                  {
                      CategoryId = 5,
                      CategoryName = "Grocery"
                  }

            );
        }
    }
}