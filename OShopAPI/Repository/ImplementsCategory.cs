using OShopAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace OShopAPI.Repository
{
    public class ImplementsCategory : ICategoryRepo
    {
        private readonly ApplicationDbContext _context;

        public ImplementsCategory(ApplicationDbContext dbContext)
        {
            _context = dbContext;
        }
        public IEnumerable<Category> GetAllCategory()
        {
            return _context.Categories.ToList();
        }
    }
}
