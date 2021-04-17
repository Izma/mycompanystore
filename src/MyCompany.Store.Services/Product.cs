using MyCompany.Store.DataAccess.Repository;
using MyCompany.Store.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Store.Services
{
    public class Product : IProduct
    {
        private readonly IProductRepository _repository;
        public Product(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<IList<ProductModel>> GetProductsAsync()
        {
            var products = await _repository.GetProductsAsync().ConfigureAwait(false);
            if (products.Any())
            {
                return products.ToList();
            }
            return new List<ProductModel>();
        }
    }
}
