using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Application.constracture.Product
{
    public interface IProductApplication
    {
        List<ProductView> GetProducts();
    }
}