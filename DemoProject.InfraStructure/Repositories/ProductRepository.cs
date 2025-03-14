using DemoProject.Application.Repostories;
using DemoProject.Domain.Entities;
using DemoProject.Infrastructure.EFCore;
using Microsoft.EntityFrameworkCore;

namespace DemoProject.Infrastructure.Repositories;

public class ProductRepository : IProductRepository
{
    private readonly AppDbContext _context;

    public ProductRepository(AppDbContext context)
    {
        _context = context;
    }

    public void AddProduct(Product product)
    {
        _context.Products.Add(product);
        _context.SaveChanges();
    }

    public List<Product> GetProducts()
    {
        var products = _context.Products.Include(p=>p.Category).ToList();   
        return products;
    }

    public void RemoveProduct(int id)
    {
        var existProduct = _context.Products.Find(id);

        if(existProduct==null)
        {
            Console.WriteLine("Not found");
            return;
        }

        _context.Products.Remove(existProduct);
        _context.SaveChanges();
    }

    public void UpdateProduct(int id, Product product)
    {
        var existProduct = _context.Products.Find(id);

        if (existProduct == null)
        {
            Console.WriteLine("Not found");
            return;
        }

        existProduct.Name = product.Name;
        _context.SaveChanges();
    }
}
