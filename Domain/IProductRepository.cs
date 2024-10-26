using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Domain
{
    public interface IProductRepository
    {
        
        List<Product> GetProducts();
        public void CreateProduct(Product product);
    }
}