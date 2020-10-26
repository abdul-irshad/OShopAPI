using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OShopAPI.Dtos;
using OShopAPI.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repository;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryRepo repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryDTO>>> GetAllCategory()
        {
            var category = await _repository.GetAllCategory();
            return Ok(category);
        }

        [HttpPost]
        public async Task<IActionResult> CareateCategory(CategoryDTO createCategory)
        {
            return Ok(await _repository.CreateCategory(createCategory));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategory(CategoryDTO updateCategory)
        {
            return Ok(await _repository.UpdateCategory(updateCategory));
        }

        [HttpDelete("{categoryId}")]
        public async Task<IActionResult> DeleteCategory(int categoryId)
        {
            return Ok(await _repository.DeleteCategory(categoryId));
        }
    }
}