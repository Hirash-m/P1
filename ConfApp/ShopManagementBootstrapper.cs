using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Application.Product;
using Application.constracture.Product;
using Infrastructure.EF;
using Domain;

namespace ConfApp
{
    public class ShopManagementBootstrapper
    {
        public static IServiceCollection AddShopManagement(IServiceCollection service, string connectionstring){
            service.AddTransient<IProductApplication,ProductApplication>();
            service.AddTransient<IProductRepository,ProductRepository>();

            return service;
        }
        
    }
}