using Microsoft.AspNetCore.Mvc;
using OShopAPI.Dtos;
using OShopAPI.Repository;
using System.Collections;
using System.Collections.Generic;

namespace OShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepo _repository;

        public CategoryController(ICategoryRepo repo)
        {
            _repository = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<CategoryDTO>> GetAllCategory()
        {
            var category = _repository.GetAllCategory();
            return Ok(category);
        }
    }
}
