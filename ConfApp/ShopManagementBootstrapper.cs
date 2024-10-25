
using Microsoft.Extensions.DependencyInjection;
using Application.Product;
using Application.constracture.Product;
using Infrastructure.EF;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace ConfApp
{
    public class ShopManagementBootstrapper
    {
        public static void AddShopManagement(IServiceCollection service, string connectionstring){
            service.AddTransient<IProductApplication,ProductApplication>();
            service.AddTransient<IProductRepository,ProductRepository>();

            service.AddDbContext<MyContect>(c =>
            {
                c.UseSqlServer(connectionstring);
            });
            
        }
        
    }
}