using OShopAPI.Models;
using System.Collections.Generic;

namespace OShopAPI.Repository
{
    public  interface ICategoryRepo
    {
        IEnumerable<Category> GetAllCategory();

    }
}
