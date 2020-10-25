using OShopAPI.Models;
using System.Collections.Generic;

namespace OShopAPI.Repository
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProduct();
    }
}
