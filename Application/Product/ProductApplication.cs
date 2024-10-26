using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.constracture.Product;
using Domain;

namespace Application.Product
{
    public class ProductApplication : IProductApplication
    {
        private readonly IProductRepository _productRepository;

        public ProductApplication(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }
        public List<ProductView> GetProducts()
        {
            var products = _productRepository.GetProducts();
        
        
        return products.Select(p => new ProductView
        {
            Name = p.Name,
            Description = p.Description,
        }).ToList();
        }

          public void CreateProduct(ProductView productView){

                    var product = new Domain.Product{Name=productView.Name
                    ,Description=productView.Description};

                _productRepository.CreateProduct(product);
        }


    }
}


    }
}