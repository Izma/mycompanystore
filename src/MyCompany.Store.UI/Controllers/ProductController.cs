using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Store.Models;
using MyCompany.Store.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Store.UI.Controllers
{
    // [Route("api/products")]
    [Produces("application/json")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }

        [HttpGet]
        [Route("api/products")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _product.GetProductsAsync().ConfigureAwait(false);
            if (products.Count > 0)
                return Ok(products);
            return NotFound();
        }

        [HttpGet]
        [Route("api/product/{productId}")]
        public async Task<IActionResult> GetProducts(int productId)
        {
            var products = await _product.GetProductsAsync().ConfigureAwait(false);
            if (products.Count > 0)
                return Ok(products);
            return NotFound();
        }

        [HttpPost]
        [Route("api/product")]
        public IActionResult SaveProduct()
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/product/{productId}")]
        public IActionResult DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/product/{productId}")]
        public IActionResult EditProduct(int productId, ProductModel productModel)
        {
            throw new NotImplementedException();
        }
    }

}
