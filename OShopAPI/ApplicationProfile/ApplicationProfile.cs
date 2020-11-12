using AutoMapper;
using OShopAPI.Dtos;
using OShopAPI.Models;

namespace OShopAPI.ApplicationProfile
{
    public class ApplicationProfile : Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Category, CategoryDTO>();
            CreateMap<CategoryDTO, Category>();

            CreateMap<Product, ProductDTO>();
            CreateMap<ProductDTO, Product>();
        }
    }
}