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
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repository;
        private readonly IMapper _mapper;

        public ProductController(IProductRepo repo, IMapper mapper)
        {
            _repository = repo;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetAllProduct()
        {
            var products = await _repository.GetAllProduct();
            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CareateProduct(ProductDTO createProduct)
        {
            return Ok(await _repository.CreateProduct(createProduct));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductDTO updateProduct)
        {
            return Ok(await _repository.UpdateProduct(updateProduct));
        }
    }
}