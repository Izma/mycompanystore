using System;

namespace MyCompany.Store.Models
{
    public class ProductModel
    {
        /// <summary>
        /// Get or set ProductId
        /// </summary>
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public bool? Status { get; set; }
        public DateTime? RegisteredOn { get; set; }
        public string RegisterBy { get; set; }
    }
}
