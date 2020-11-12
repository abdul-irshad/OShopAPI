using OShopAPI.Dtos;
using OShopAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OShopAPI.Repository
{
    public interface IProductRepo
    {
        Task<ServiceResponse<IEnumerable<ProductDTO>>> GetAllProduct();

        Task<ServiceResponse<IEnumerable<ProductDTO>>> CreateProduct(ProductDTO product);

        Task<ServiceResponse<ProductDTO>> UpdateProduct(ProductDTO product);

        Task<ServiceResponse<IEnumerable<ProductDTO>>> DeleteProduct(int id);
    }
}