using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Infrastructure.EF
{
    public class ProductRepository : IProductRepository
    {
        private readonly MyContect _ctx;

        public ProductRepository(MyContect ctx)
        {
            _ctx = ctx;
        }

        public List<Product> GetProducts()
        {
            return _ctx.products.ToList();
        }
    }
}