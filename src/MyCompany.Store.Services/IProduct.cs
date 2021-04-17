using MyCompany.Store.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyCompany.Store.Services
{
    public interface IProduct
    {
        Task<IList<ProductModel>> GetProductsAsync();
    }
}
