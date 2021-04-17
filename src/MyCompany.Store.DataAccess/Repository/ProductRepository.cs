using MyCompany.Store.DataAccess.Connection;
using MyCompany.Store.Models;
using System;
using System.Linq;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace MyCompany.Store.DataAccess.Repository
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(IStoreConnection connection) : base(connection)
        {
        }

        public async Task<IQueryable<ProductModel>> GetProductsAsync()
        {
            return await WithConnection(async db =>
            {
                var products = await db.QueryAsync<ProductModel>(sql: "[products].[spGetProducts]", param: null, commandType: CommandType.StoredProcedure).ConfigureAwait(false);
                return products.AsQueryable();
            }).ConfigureAwait(false);
        }
    }
}
