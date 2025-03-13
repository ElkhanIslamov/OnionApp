using DemoProject.Application.Services;
using DemoProject.Domain.Entities;
using DemoProject.Infrastructure.EFCore;
using DemoProject.Infrastructure.Repositories;

namespace OnionArchitectureDemoProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var appDbContext = new AppDbContext();
            ProductRepository productRepository = new ProductRepository(appDbContext);
            ProductManager productManager = new ProductManager(productRepository);

            //Product product = new Product
            //{
            //    Name = "Apelsin",
            //    Price = 2
            //};
            //productRepository.AddProduct(product);

            //productRepository.RemoveProduct(1);
            //productRepository.UpdateProduct(2, new Product { Name = "Alca" });


           foreach(var item in productManager.GetProducts())
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
