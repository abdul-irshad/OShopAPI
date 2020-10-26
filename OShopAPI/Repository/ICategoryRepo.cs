using OShopAPI.Dtos;
using OShopAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OShopAPI.Repository
{
    public interface ICategoryRepo
    {
        Task<ServiceResponse<IEnumerable<CategoryDTO>>> GetAllCategory();

        Task<ServiceResponse<IEnumerable<CategoryDTO>>> CreateCategory(CategoryDTO category);

        Task<ServiceResponse<CategoryDTO>> UpdateCategory(CategoryDTO category);

        Task<ServiceResponse<IEnumerable<CategoryDTO>>> DeleteCategory(int id);
    }
}