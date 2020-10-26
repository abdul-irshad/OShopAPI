using AutoMapper;
using Microsoft.EntityFrameworkCore;
using OShopAPI.Dtos;
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
        private readonly IMapper _mapper;

        public ImplementsCategory(ApplicationDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<CategoryDTO>>> CreateCategory(CategoryDTO category)
        {
            ServiceResponse<IEnumerable<CategoryDTO>> serviceResponse = new ServiceResponse<IEnumerable<CategoryDTO>>();
            Category cat = _mapper.Map<Category>(category);
            await _context.Categories.AddAsync(cat);
            await _context.SaveChangesAsync();
            serviceResponse.Data = (_context.Categories.Select(c => _mapper.Map<CategoryDTO>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<CategoryDTO>>> DeleteCategory(int id)
        {
            ServiceResponse<IEnumerable<CategoryDTO>> serviceResponse = new ServiceResponse<IEnumerable<CategoryDTO>>();

            try
            {
                Category category = await _context.Categories.FirstAsync(c => c.CategoryId == id);
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();

                serviceResponse.Data = (_context.Categories.Select(c => _mapper.Map<CategoryDTO>(c))).ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }
            return serviceResponse;
        }

        public async Task<ServiceResponse<IEnumerable<CategoryDTO>>> GetAllCategory()
        {
            ServiceResponse<IEnumerable<CategoryDTO>> serviceResponse = new ServiceResponse<IEnumerable<CategoryDTO>>();
            IEnumerable<Category> dbCategory = await _context.Categories.ToListAsync();
            serviceResponse.Data = (dbCategory.Select(c => _mapper.Map<CategoryDTO>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<CategoryDTO>> UpdateCategory(CategoryDTO updateCategory)
        {
            ServiceResponse<CategoryDTO> serviceResponse = new ServiceResponse<CategoryDTO>();

            try
            {
                Category category = await _context.Categories.FirstOrDefaultAsync(c => c.CategoryId == updateCategory.CategoryId);
                category.CategoryName = updateCategory.CategoryName;

                _context.Categories.Update(category);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<CategoryDTO>(category);
            }
            catch (Exception ex)
            {
                serviceResponse.Success = false;
                serviceResponse.Message = ex.Message;
            }

            return serviceResponse;
        }
    }
}