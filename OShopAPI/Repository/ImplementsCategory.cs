using OShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
