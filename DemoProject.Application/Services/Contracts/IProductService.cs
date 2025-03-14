using DemoProject.Application.DTOs;
using DemoProject.Domain.Entities;

namespace DemoProject.Application.Services.Contracts;

public interface IProductService
{
    List<ProductDto> GetProducts();
    void AddProduct(Product product);
    void RemoveProduct(int id);
    void UpdateProduct(int id, Product product);
}
