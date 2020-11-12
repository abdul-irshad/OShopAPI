using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OShopAPI.Dtos;
using OShopAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OShopAPI.Repository
{
    public class ImplementsProduct : IProductRepo
    {
        private readonly ApplicationDbContext _context;
        private readonly IMapper _mapper;

        public ImplementsProduct(ApplicationDbContext dbContext, IMapper mapper)
        {
            _context = dbContext;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IEnumerable<ProductDTO>>> CreateProduct(ProductDTO product)
        {
            ServiceResponse<IEnumerable<ProductDTO>> serviceResponse = new ServiceResponse<IEnumerable<ProductDTO>>();
            Product pro = _mapper.Map<Product>(product);
            await _context.Products.AddAsync(pro);
            await _context.SaveChangesAsync();
            serviceResponse.Data = (_context.Products.Select(c => _mapper.Map<ProductDTO>(c))).ToList();
            return serviceResponse;
        }

        public Task<ServiceResponse<IEnumerable<ProductDTO>>> DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        public async Task<ServiceResponse<IEnumerable<ProductDTO>>> GetAllProduct()
        {
            ServiceResponse<IEnumerable<ProductDTO>> serviceResponse = new ServiceResponse<IEnumerable<ProductDTO>>();
            IEnumerable<Product> dbCategory = await _context.Products.ToListAsync();
            serviceResponse.Data = (dbCategory.Select(c => _mapper.Map<ProductDTO>(c))).ToList();
            return serviceResponse;
        }

        public async Task<ServiceResponse<ProductDTO>> UpdateProduct(ProductDTO updateProduct)
        {
            ServiceResponse<ProductDTO> serviceResponse = new ServiceResponse<ProductDTO>();

            try
            {
                Product product = await _context.Products.FirstOrDefaultAsync(c => c.ProductID == updateProduct.ProductID);

                product.ProductTitle = updateProduct.ProductTitle;
                product.Price = updateProduct.Price;
                product.CategoryID = updateProduct.CategoryID;
                product.ImageURL = updateProduct.ImageURL;

                _context.Products.Update(product);
                await _context.SaveChangesAsync();

                serviceResponse.Data = _mapper.Map<ProductDTO>(product);
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