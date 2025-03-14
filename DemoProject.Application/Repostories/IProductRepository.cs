using DemoProject.Application.DTOs;
using DemoProject.Domain.Entities;

namespace DemoProject.Application.Repostories;

public interface IProductRepository
{
    List<Product> GetProducts();
    void AddProduct(Product product);
    void RemoveProduct(int id);
    void UpdateProduct(int id, Product product);
}
